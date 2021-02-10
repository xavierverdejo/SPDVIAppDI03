CREATE PROCEDURE [dbo].[uspGetProductSizes]
@ID int
AS
BEGIN
SELECT Production.Product.ProductID, Production.Product.Size 
FROM Production.Product INNER JOIN Production.ProductSubcategory 
ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID 
INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID 
INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID 
WHERE Product.ProductModelID = @ID
END