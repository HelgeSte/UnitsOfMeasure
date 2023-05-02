/* All SameUnit_X__uom & SameUnit_X__namingSystem (X = 1-3)has to be inserted into new SameUnit table 
   NB: SameUnit_3_namingSystem might be NULL */
select UomId, Name, _id, SameUnit_3__namingSystem, SameUnit_3__uom from UnitsOfMeasure WHERE SameUnit_3__uom IS NOT NULL
select UomId, Name, _id, SameUnit_3__namingSystem from UnitsOfMeasure WHERE SameUnit_3__uom IS NOT NULL
/* Check if namingSystem is NULL when uom isn't NULL and vica versa */
select UomId FROM UnitsOfMeasure WHERE SameUnit_3__uom IS NULL and SameUnit_3__namingSystem IS NOT NULL
select UomId FROM UnitsOfMeasure WHERE SameUnit_3__uom IS NOT NULL and SameUnit_3__namingSystem IS NULL
/* It should be ok to use NOT NULL in my SameUnit table, if there is no inconsistence with NULL */

/* All QuantityType_X(X = 1-12) has to be inserted into new QuantityType table */
select UomId, Name, _id from UnitsOfMeasure WHERE QuantityType_12 IS NOT NULL

/* When this is done, all QuantityType and SameUnit columns has to be deleted from the UnitsOfMeasure table */
INSERT INTO QuantityType (UomId, QuantityType)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_1
FROM UnitsOfMeasure
WHERE QuantityType_1 IS NOT NULL

INSERT INTO SameUnit (UomId, SameUnit_uom, SameUnit_namingSystem)
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.SameUnit_3__uom, UnitsOfMeasure.SameUnit_3__namingSystem
FROM UnitsOfMeasure
WHERE Same IS NOT NULL

/* Althernative method if the above fails */
SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.QuantityType_1
INTO QuantityType (UomId, QuantityType)
FROM UnitsOfMeasure
WHERE QuantityType_1 IS NOT NULL; 

SELECT UnitsOfMeasure.UomId, UnitsOfMeasure.SameUnit_3__uom, UnitsOfMeasure.SameUnit_3__namingSystem
INTO SameUnit (UomId, SameUnit_uom, SameUnit_namingSystem)
FROM UnitsOfMeasure
WHERE condition; 