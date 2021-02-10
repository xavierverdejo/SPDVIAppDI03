CREATE PROCEDURE uspGetAllProductIds
AS
BEGIN
	SELECT DISTINCT Product.ProductModelID
	FROM Production.Product
	WHERE Product.ProductModelID IS NOT NULL
	ORDER BY ProductModelID
END