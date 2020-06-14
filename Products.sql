create TABLE Categories(id int, name varchar(30));
create TABLE Products(id int, name varchar(30), category int);
INSERT INTO Categories(id,name) VALUES (1,'Kruppi'), (2,'Soki'), (3,'Myaso');
INSERT INTO Products(id,name, category) VALUES (1,'Grechka',1), (2,'Dobriy',2), 
(3,'Papa Mozhet',3),(4,'Ris',1), (5,'Ovyos',1), (6,'Rich',2), (7,'Grechka', 2), (8,'Mish',NULL);
SELECT p.name 'Product', c.name 'Category' from Products p left JOIN Categories c on p.category = c.id;
