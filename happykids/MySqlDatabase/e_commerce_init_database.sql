create database e_commerce;
use e_commerce;

DROP TABLE IF EXISTS Customer;
Create table Customer(
custID      int             AUTO_INCREMENT,
email       varchar(50)		NOT NULL,
password    varchar(10)		NOT NULL,
fname       varchar(30)		NULL DEFAULT ' ',
lname       varchar(30)	    NULL DEFAULT ' ',
phone       varchar(10)	    NULL DEFAULT ' ',
UNIQUE (email),
Primary key (custID));

DROP TABLE IF EXISTS Address;
Create table Address(
addressID   int  AUTO_INCREMENT,
custID      int  NOT NULL,
fname       varchar(30)		NOT NULL DEFAULT ' ',
lname       varchar(30)	    NOT NULL DEFAULT ' ',
companyname varchar(30)	    NULL DEFAULT ' ',
address     varchar(30)	    NOT NULL DEFAULT ' ',
address2    varchar(30)	    NULL DEFAULT ' ',
city        varchar(30)	    NOT NULL DEFAULT ' ',
country     varchar(30)	    NOT NULL DEFAULT ' ',
region      varchar(30)	    NOT NULL DEFAULT ' ',
postalcode  varchar(10)	    NOT NULL DEFAULT ' ',
phone       varchar(10)	    NULL DEFAULT ' ',
isAddress   char  not null DEFAULT 'N',
foreign key (custID) references Customer(custID),
Primary key (addressID));

DROP TABLE IF EXISTS CardType;
Create table CardType(
cardType    varchar(10) NOT NULL,
image MEDIUMBLOB NOT NULL,
Primary key (CardType));


DROP TABLE IF EXISTS Wallet;
Create table Wallet(
walletID    int   AUTO_INCREMENT,
custID      int  NOT NULL,
cardNo      varchar(16) NULL,
cardName    varchar(30) NOT NULL DEFAULT '',
expireDate  varchar(5),
cvvCode     varchar(3),
cardType    varchar(10),
isDefault   char default 'N',
foreign key (custID) references Customer(custID),
UNIQUE (custID,cardNo),
Primary key (WalletID));

DROP TABLE IF EXISTS Coupon;
Create table Coupon(
couponCode  varchar(10) NOT NULL,
remaining    int NOT NULL DEFAULT 0,
amount       int NOT NULL DEFAULT 0,
discount 	 int NOT NULL DEFAULT 0,
Primary key (couponCode)
);


DROP TABLE IF EXISTS Orders;
Create table Orders(
orderID     int   AUTO_INCREMENT,
orderDate   DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
custID      int  NOT NULL,
addressID   int  NOT NULL,
shippingID  varchar(20)   DEFAULT '',
shippingFee double  DEFAULT 0.0,
totalAmount double  DEFAULT 0.0,
couponCode  varchar(10)   DEFAULT '',
note        varchar(40)   DEFAULT '',
isPayment    char    DEFAULT 'N',
isTransport  char    DEFAULT 'N',
isComplete   char    DEFAULT 'N',
foreign key (custID) references Customer(custID),
foreign key (addressID) references Address(addressID),
foreign key (couponCode) references coupon(couponCode),
Primary key (orderID));

DROP TABLE IF EXISTS Payment;
Create table Payment(
paymentID   int   AUTO_INCREMENT,
paymentDate   DATETIME   DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
orderID     int not null,
custID      int  NOT NULL,
cardNo      varchar(16) NOT NULL,
cardName    varchar(30) NOT NULL,
expireDate  varchar(5)  NOT NULL,
cvvCode     varchar(3)  NOT NULL,
cardType    varchar(10)  NOT NULL,
foreign key (custID) references Customer(custID),
foreign key (orderID) references Orders(orderID),
Primary key (paymentID));

DROP TABLE IF EXISTS Category;
Create table Category(
categoryID    int    AUTO_INCREMENT,
categoryName        varchar(20) NOT NULL,
Primary key (categoryID)
);


DROP TABLE IF EXISTS Color;
Create table Color(
colorID    int    AUTO_INCREMENT,
colorName        varchar(10) NOT NULL,
Primary key (colorID)
);

DROP TABLE IF EXISTS Size;
Create table Size(
sizeID         int   AUTO_INCREMENT,
sizeDesc      varchar(20),
Primary key (sizeID)
);

DROP TABLE IF EXISTS Product;
Create table Product(
productID    int    AUTO_INCREMENT,
price double NOT NULL DEFAULT 0.0,
name  varchar(30) not  null,
info  varchar(200)  null,
refundPolicy varchar(200) null,
description varchar(200) null,
categoryID int not  null,
foreign key (categoryID) references Category(categoryID),
Primary key (ProductID)
);


DROP TABLE IF EXISTS Wishlist;
Create table Wishlist(
custID      int NOT NULL,
productID   int NOT NULL,
foreign key (custID) references Customer(custID),
foreign key (productID) references Product(productID),
Primary key (custID,productID)
);

DROP TABLE IF EXISTS Subscription;
Create table Subscription(
custID      int NOT NULL,
productID   int NOT NULL,
foreign key (custID) references Customer(custID),
foreign key (productID) references Product(productID),
Primary key (custID,productID)
);


-- alter table productcolor add isdefault char;

DROP TABLE IF EXISTS ProductColor;
Create table ProductColor(
ProductColorID     int    AUTO_INCREMENT,
productID  		   int NOT NULL ,
colorID			   int NOT NULL,
image              MEDIUMBLOB NOT NULL,
isdefault          char,
foreign key (colorID) references Color(colorID),
UNIQUE (productID,colorID),
Primary key (ProductColorID)
);

DROP TABLE IF EXISTS ProductDetail;
Create table ProductDetail(
ProductDetailID    int    AUTO_INCREMENT,
ProductColorID  		   int NOT NULL ,
sizeID               int  NOT NULL,
remaining          int  NOT NULL DEFAULT 0,
amount             int  NOT NULL DEFAULT 0,
foreign key (ProductColorID) references ProductColor(ProductColorID),
foreign key (sizeID) references Size(sizeID),
UNIQUE (ProductColorID,sizeID),
Primary key (ProductDetailID)
);

DROP TABLE IF EXISTS Basket;
Create table Basket(
custID               int NOT NULL,
productDetailID      int NOT NULL,
amount               int NOT NULL DEFAULT 0,
foreign key (custID) references Customer(custID),
foreign key (productDetailID) references ProductDetail(productDetailID),
Primary key (custID,productDetailID)
);

DROP TABLE IF EXISTS ItemsOrder;
Create table ItemsOrder(
OrderID     int NOT NULL,
productDetailID int  NOT NULL,
amount      int NOT NULL DEFAULT 0,
foreign key (OrderID) references Orders(OrderID),
foreign key (productDetailID) references ProductDetail(productDetailID),
Primary key (OrderID,productDetailID)
);

DROP TABLE IF EXISTS Banner;
Create table Banner(
BannerID           int    AUTO_INCREMENT,
image              MEDIUMBLOB NOT NULL,
categoryID         int not  null,
foreign key (categoryID) references Category(categoryID),
Primary key (BannerID)
);




