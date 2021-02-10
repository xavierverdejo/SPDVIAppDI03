CREATE PROCEDURE [dbo].[uspGetProductModelById]
@ID int
AS
BEGIN
	SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto, Product.ListPrice FROM Production.ProductModel 
	JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID 
	JOIN Production. ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID 
	JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID
	WHERE Product.ProductModelID = @ID
	ORDER BY Product.ListPrice;
END