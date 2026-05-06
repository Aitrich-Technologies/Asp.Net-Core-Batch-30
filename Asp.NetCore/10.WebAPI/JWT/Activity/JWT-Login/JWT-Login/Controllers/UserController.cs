using JWT_Login.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT_Login.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _context;
        private readonly IConfiguration _configuration;

        public UserController(UserDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // ✅ REGISTER
        [HttpPost("Registration")]
        public IActionResult Registration(UserDto userDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingUser = _context.users.FirstOrDefault(x => x.Email == userDto.Email);

            if (existingUser != null)
                return BadRequest("User already exists");

            var user = new User
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Password = userDto.Password,
                Role = userDto.Role
            };

            _context.users.Add(user);
            _context.SaveChanges();

            return Ok("User Registered Successfully");
        }

        // ✅ LOGIN + TOKEN
        [HttpPost("Login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var user = _context.users
                .FirstOrDefault(x => x.Email == loginDto.Email && x.Password == loginDto.Password);

            if (user == null)
                return Unauthorized("Invalid credentials");

            // ✅ CORRECT CLAIMS
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Email, user.Email), // ✅ FIXED
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["JWT:Key"])
            );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: creds
            );

            var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new
            {
                Token = tokenValue
            });
        }

        // ✅ GET LOGGED USER
        [HttpGet("user")]
        [Authorize]
        public IActionResult GetUser()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var email = User.FindFirst(ClaimTypes.Email)?.Value;
            var role = User.FindFirst(ClaimTypes.Role)?.Value;

            return Ok(new
            {
                UserId = userId,
                Email = email,
                Role = role
            });
        }

        // ✅ DELETE USER (ROLE BASED)
        [HttpDelete("DeleteUser")]
        [Authorize(Roles = "ADMIN,JOBPROVIDER")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.users.FirstOrDefault(x => x.UserId == id);

            if (user == null)
                return NotFound("User not found");

            _context.users.Remove(user);
            _context.SaveChanges();

            return Ok("User deleted successfully");
        }
    }
}
//        private readonly UserDbContext _userDbContext;
//        private readonly IConfiguration configuration;
//        public UserController(UserDbContext userDbContext, IConfiguration _configuration)
//        {

//            _userDbContext = userDbContext;
//            configuration = _configuration;
//        }

//        [HttpPost]
//        [Route("Registration")]
//        public IActionResult Registration(UserDto userDto)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            var objUser = _userDbContext.users.FirstOrDefault(x => x.Email == userDto.Email);
//            if (objUser == null)
//            {
//                _userDbContext.users.Add(new Model.User
//                {
//                    FirstName = userDto.FirstName,
//                    LastName = userDto.LastName,
//                    Email = userDto.Email,
//                    Password = userDto.Password,
//                    Role = userDto.Role,
//                });
//                _userDbContext.SaveChanges();
//                return Ok("User Registered Successfully");
//            }
//            else
//            {
//                return BadRequest("User Already Exists with same email address");
//            }
//        }

//        [HttpPost]
//        [Route("Login")]
//        public IActionResult Login(LoginDto loginDto)
//        {
//            var user = _userDbContext.users.FirstOrDefault(x => x.Email == loginDto.Email && x.Password == loginDto.Password);
//            if (user != null)
//            {
//                var claims = new[]
//                {
//                     new Claim(JwtRegisteredClaimNames.Sub, configuration["JWT:Subject"]),
//                     new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
//                     new Claim("UserId", user.UserId.ToString()),
//                     new Claim("Email", user.Email),
//                     new Claim(ClaimTypes.Role, user.Role.ToString()) // Add Role claim
//                };
//                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]));

//                var signIn=new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

//                var token=new JwtSecurityToken(
//                    configuration["JWT:Issuer"],
//                    configuration["JWT:Audience"],
//                    claims,
//                    expires:DateTime.UtcNow.AddMinutes(60),
//                    signingCredentials:signIn
//                    );

//                string tokenValue=new JwtSecurityTokenHandler().WriteToken(token);
//                return Ok(new {Token=tokenValue,User=user});
//            }
//            return NoContent();
//        }

//        [HttpGet]
//        [Route("GetUser")]
//        [Authorize(Roles = "JOBSEEKER")]
//        public IActionResult GetUser(int id)
//        {
//            var user = _userDbContext.users.FirstOrDefault(x => x.UserId == id);
//            if (user != null)
//            {
//                return Ok(user);
//            }
//            else
//                return NoContent();
//        }

//        [HttpDelete]
//        [Route("DeleteUser")]
//        [Authorize(Roles = "ADMIN,JOBPROVIDER")]
//        public IActionResult DeleteUser(int id)
//        {
//            var user = _userDbContext.users.FirstOrDefault(x => x.UserId == id);
//            if (user != null)
//            {
//                _userDbContext.users.Remove(user);
//                _userDbContext.SaveChanges();
//                return Ok("User Deleted Successfully");
//            }
//            return NotFound("User Not Found");
//        }

//    }
//}
