use e_commerce;
DROP TABLE IF EXISTS Category;
Create table Category(
categoryID    int    AUTO_INCREMENT,
categoryName        varchar(20) NOT NULL,
Primary key (categoryID)
);

DROP TABLE IF EXISTS Color;
Create table Color(
colorID    int    AUTO_INCREMENT,
colorNmae        varchar(10) NOT NULL,
Primary key (colorID)
);

DROP TABLE IF EXISTS Size;
Create table Size(
size         int  NOT NULL,
Primary key (size)
);

INSERT INTO Address(fname,custid) VALUES('bankadd',1);

INSERT INTO Category(categoryName) VALUES('T shirts');
INSERT INTO Category(categoryName) VALUES('Bodysuits');
INSERT INTO Category(categoryName) VALUES('baby pants');

INSERT INTO Color(colorName) VALUES('Blue');
INSERT INTO Color(colorName) VALUES('Cream');
INSERT INTO Color(colorName) VALUES('Green');
INSERT INTO Color(colorName) VALUES('Light Pink');
INSERT INTO Color(colorName) VALUES('Peach');
INSERT INTO Color(colorName) VALUES('Terracota');
INSERT INTO Color(colorName) VALUES('White');
INSERT INTO Coupon(couponCode) VALUES('NoCode');

INSERT INTO size(sizeDesc) VALUES('0-3 months');
INSERT INTO size(sizeDesc) VALUES('3-6 months');
INSERT INTO size(sizeDesc) VALUES('6-12 months');
INSERT INTO size(sizeDesc) VALUES('12-18 months');
INSERT INTO size(sizeDesc) VALUES('18-24 months');
INSERT INTO size(sizeDesc) VALUES('2 years');
INSERT INTO size(sizeDesc) VALUES('3 years');

INSERT INTO Banner(categoryID,image) VALUES(1,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Banner/Banner1.png'));
INSERT INTO Banner(categoryID,image) VALUES(1,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Banner/Banner2.png'));
INSERT INTO Banner(categoryID,image) VALUES(1,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Banner/Banner3.png'));
INSERT INTO Banner(categoryID,image) VALUES(1,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Banner/Banner4- Our story.png'));


DROP TABLE IF EXISTS Product;
Create table Product(
productID    int    AUTO_INCREMENT,
price double NOT NULL DEFAULT 0.0,
name  varchar(30) not  null,
info  varchar(50)  null,
refundPolicy varchar(50) null,
categoryID int not  null,
foreign key (categoryID) references Category(categoryID),
Primary key (ProductID)
);
select * from Category;
select * from Color;

delete from Product where ProductId= 7; 
delete from ProductColor where ProductId= 7;
INSERT INTO Product(price,categoryID,name,info,refundPolicy,description) VALUES(199.00,1,'I''m a product','I''m a product detail. I''m a great place to add more information about your product such as sizing, material',
'I''m a return and refund policy.','I''m a product description. I''m a great place to include more information about your product. Buyers like to know what they''re getting before they purchase.');

INSERT INTO Product(price,categoryID,name,info,refundPolicy,description) VALUES(199.00,2,'I''m a product','I''m a product detail. I''m a great place to add more information about your product such as sizing, material',
'I''m a return and refund policy.','I''m a product description. I''m a great place to include more information about your product. Buyers like to know what they''re getting before they purchase.');
-- 4,5,6,7
INSERT INTO ProductColor(productID,colorID,image) VALUES(1,3,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product1.png'));
INSERT INTO ProductColor(productID,colorID,image) VALUES(1,6,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product1_2.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(2,5,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product2.png'));
INSERT INTO ProductColor(productID,colorID,image) VALUES(2,1,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product2_2.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(3,7,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product3.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(4,4,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product4.png'));

update  ProductColor set colorID = 7 where productID = 5;
update  ProductColor set colorID = 7 where productID = 6;
update  ProductColor set colorID = 7 where productID = 7;
update  ProductColor set colorID = 2 where productID = 8;
update  ProductColor set colorID = 7 where productID = 9;
update  ProductColor set colorID = 7 where productID = 10;

INSERT INTO ProductColor(productID,colorID,image) VALUES(5,1,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product5.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(6,1,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product6.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(7,2,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product7.png'));
delete from ProductColor where ProductId= 7;
INSERT INTO ProductColor(productID,colorID,image) VALUES(7,7,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product7.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(8,2,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product8.png'));
delete from ProductColor where ProductId= 8;
INSERT INTO ProductColor(productID,colorID,image) VALUES(8,2,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product8.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(9,7,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product9.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(10,7,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product10.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(11,1,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product11.png'));

INSERT INTO ProductColor(productID,colorID,image) VALUES(12,4,LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product12.png'));

select * from ProductColor;


INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(1,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(1,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(1,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(1,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(2,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(2,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(2,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(2,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(3,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(3,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(3,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(3,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(4,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(4,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(4,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(4,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(5,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(5,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(5,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(5,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(6,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(6,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(6,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(6,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(7,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(7,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(7,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(7,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(8,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(8,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(8,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(8,7,99,99);


INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(10,1,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(10,2,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(10,3,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(10,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(10,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(10,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(10,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(12,1,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(12,2,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(12,3,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(12,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(12,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(12,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(12,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(13,1,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(13,2,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(13,3,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(13,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(13,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(13,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(13,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(14,1,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(14,2,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(14,3,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(14,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(14,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(14,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(14,7,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(15,1,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(15,2,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(15,3,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(15,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(15,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(15,6,99,99);

INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(16,1,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(16,3,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(16,4,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(16,5,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(16,6,99,99);
INSERT INTO ProductDetail(ProductColorID,sizeID,remaining,amount) VALUES(16,7,99,99);


-- SELECT LOAD_FILE('C:\happykid\Images\product1.png');
-- SELECT LOAD_FILE('C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/happykid/Images/Product1.png');

-- SHOW VARIABLES LIKE "secure_file_priv";
