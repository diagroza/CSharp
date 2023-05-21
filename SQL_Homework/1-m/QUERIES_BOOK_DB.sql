
--insert--
insert into BOOK
VALUES
(1005, 'Node.JS', 1258),
(1006, 'The Intelligent Investor', 1258),
(1007, 'Culture Map', 1547);

insert into AUTHOR
VALUES
(1244, 'Seastian Springer', '1005'),
(1245, 'Benjamin Graham', 1006), 
(2548, 'Erin Meyer', 1007);

---updates---

update AUTHOR
set AUTH_NAME = 'Sebastian Springer'
where AUTH_NAME = 'Seastian Springer';

update BOOK
set INVENTORY_ID = '2015'
WHERE INVENTORY_ID = '1258';

---select

select * from BOOK;
select * from AUTHOR;

select * from BOOK where BOOK_ID between 1000 and 1005;
select Name from BOOK where Name like 'TH%';
select * from BOOK order by INVENTORY_ID DESC;

---INNER---
select * from BOOK b
INNER JOIN AUTHOR a
on b.book_id = a.book_id;


---procedure---
CREATE PROCEDURE myBooks
AS
BEGIN 
SELECT 
     NAME,
	 AUTH_NAME
FROM 
	BOOK.AUTHOR
order by 
	name;
END


---FUNCTION---
CREATE FUNCTION returnNameandAUTHOR
(
@Name varchar(150),
@AUTH_NAME VARCHAR (150)
)
returns varchar(300)
As
Begin return (Select @Name + ' ' + @AUTH_NAME);
END

DROP TABLE AUTHORS;