CREATE TABLE Employee (
    EmpNo BIGINT,
    EName VARCHAR(50),
    DeptNo BIGINT,
    Job VARCHAR(10),
    HireDate DATETIME
);

CREATE TABLE Dept (
    DeptNo BIGINT,
    DName VARCHAR(20),
    Loc VARCHAR(20)
);

CREATE TABLE TS_Company_Master (
    Id INT,
    Name VARCHAR(50),
    Remarks VARCHAR(200)
);

CREATE TABLE TS_Group_Master (
    Id INT,
    Name VARCHAR(50),
    Remarks VARCHAR(200)
);

CREATE TABLE TS_Item_Master (
    Id INT,
    Name VARCHAR(50),
    Company_Id INT,
    Group_Id INT,
    Rate DECIMAL(10,2),
    Remarks VARCHAR(200)
);

CREATE TABLE TS_Purchase_Header (
    Id INT,
    Purchase_No VARCHAR(20),
    Trns_Date DATE,
    Total DECIMAL(10,2),
    Remarks VARCHAR(200)
);

CREATE TABLE TS_Purchase_Detail (
    Id INT,
    Header_Id INT,
    Sl_No INT,
    Item_Id INT,
    Qty INT,
    Rate DECIMAL(10,2),
    Amount DECIMAL(10,2)
);

INSERT INTO TS_Company_Master VALUES (1, 'P&G', '');
INSERT INTO TS_Company_Master VALUES (2, 'XENICAL', '');
INSERT INTO TS_Company_Master VALUES (3, 'J&J', '');
INSERT INTO TS_Company_Master VALUES (4, 'JAC', '');

INSERT INTO TS_Group_Master VALUES (1, 'INHALER', '');
INSERT INTO TS_Group_Master VALUES (2, 'DROPS', '');
INSERT INTO TS_Group_Master VALUES (3, 'POWDER', '');
INSERT INTO TS_Group_Master VALUES (4, 'OINTMENT', '');

DELETE FROM TS_Company_Master WHERE Id = 1;
DELETE FROM TS_Group_Master WHERE Name = 'INHALER';


UPDATE TS_Company_Master
SET Name = 'P&G'
WHERE Id = 2;

UPDATE Employee
SET EName = 'UpdatedName'
WHERE EmpNo = 2000;


DROP TABLE TS_Company_Master;

ALTER TABLE TS_Group_Master Add new_column bigint ;

EXEC sp_rename 'TS_Purchase_Detail', 'TS_Purchase_Detail';

EXEC sp_renamedb example,sample


