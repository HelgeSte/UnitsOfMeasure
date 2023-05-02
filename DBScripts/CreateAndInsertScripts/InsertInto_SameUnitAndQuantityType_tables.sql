CREATE TABLE SameUnit (
    SameUnitId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    SameUnit_uom varchar(50),
	SameUnit_namingSystem varchar(50),
    UomId int FOREIGN KEY REFERENCES UnitsOfMeasure(UomId)
); 

/* Insert SameUnit 1-3 */
INSERT INTO SameUnit (UomId, SameUnit_uom, SameUnit_namingSystem)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.SameUnit_3__uom, UnitsOfMeasure.SameUnit_3__namingSystem
FROM UnitsOfMeasure
WHERE SameUnit_3__uom IS NOT NULL

INSERT INTO SameUnit (UomId, SameUnit_uom, SameUnit_namingSystem)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.SameUnit_2__uom, UnitsOfMeasure.SameUnit_2__namingSystem
FROM UnitsOfMeasure
WHERE SameUnit_2__uom IS NOT NULL /* Check that SameUnit_2 for UomID 341 is added */

INSERT INTO SameUnit (UomId, SameUnit_uom, SameUnit_namingSystem)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.SameUnit_1__uom, UnitsOfMeasure.SameUnit_1__namingSystem
FROM UnitsOfMeasure
WHERE SameUnit_1__uom IS NOT NULL /* Check that SameUnit_2 for UomID 33 and 439 is added */

INSERT INTO SameUnit (UomId, SameUnit_uom, SameUnit_namingSystem)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.SameUnit_0__uom, UnitsOfMeasure.SameUnit_0__namingSystem
FROM UnitsOfMeasure
WHERE SameUnit_0__uom IS NOT NULL /* Check that SameUnit_2 for UomID 437 and 438 is added */


/* Create QuantityType table */
CREATE TABLE QuantityType (
    QuantityTypeId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    QuantityType varchar(200),
    UomId int FOREIGN KEY REFERENCES UnitsOfMeasure(UomId)
); 
/* Insert QuantityType 0-12 */
INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_0
FROM UnitsOfMeasure
WHERE QuantityType_0 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_1
FROM UnitsOfMeasure
WHERE QuantityType_1 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_2
FROM UnitsOfMeasure
WHERE QuantityType_2 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_3
FROM UnitsOfMeasure
WHERE QuantityType_3 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_4
FROM UnitsOfMeasure
WHERE QuantityType_4 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_5
FROM UnitsOfMeasure
WHERE QuantityType_5 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_6
FROM UnitsOfMeasure
WHERE QuantityType_6 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_7
FROM UnitsOfMeasure
WHERE QuantityType_7 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_8
FROM UnitsOfMeasure
WHERE QuantityType_8 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_9
FROM UnitsOfMeasure
WHERE QuantityType_9 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_10
FROM UnitsOfMeasure
WHERE QuantityType_10 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_11
FROM UnitsOfMeasure
WHERE QuantityType_11 IS NOT NULL

INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_12
FROM UnitsOfMeasure
WHERE QuantityType_12 IS NOT NULL

/* One Unit has no QuantityType */
  /* 1089 has no QuantityType_0, so 'SELECT DISTINCT UomId FROM QuantityType' shows only 1289 units, which is not an error */
  SELECT * FROM UnitsOfMeasure WHERE UomId = 1089 // QuantityType is also null in http://w3.energistics.org/uom/poscUnits22.xml

