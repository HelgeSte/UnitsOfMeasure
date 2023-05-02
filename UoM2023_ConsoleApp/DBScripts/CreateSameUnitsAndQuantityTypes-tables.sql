CREATE TABLE SameUnit (
    SameUnitId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    SameUnit_uom varchar(50),
	SameUnit_namingSystem varchar(50),
    UomId int FOREIGN KEY REFERENCES UnitsOfMeasure(UomId)
); 

CREATE TABLE QuantityType (
    QuantityTypeId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    QuantityType varchar(200),
    UomId int FOREIGN KEY REFERENCES UnitsOfMeasure(UomId)
); 