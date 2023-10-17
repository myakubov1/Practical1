SELECT 
    ProductName AS 'Product Name', 
    COALESCE(CategoryName, NULL) AS 'Category Name' --Вместо NULL можно использовать словосочение, допустим, "Без категории"
FROM 
    Products
LEFT JOIN 
    ProductCategory ON Products.ProductID = ProductCategory.ProductID
LEFT JOIN 
    Categories ON ProductCategory.CategoryID = Categories.CategoryID;
   