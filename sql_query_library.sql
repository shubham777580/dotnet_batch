INSERT INTO `library_schema`.`library_student_table`
(`library_student_id`,
`library_student_name`,
`library_student_book_borrowed`)
VALUES
(1, "mohnish", "physics"),(2, "shubham","chemistry"),
(3, "sumit", "maths"),(4, "tanmay","harry_potter"),
(5, "vikram", "marvel"),(6, "sahil","dc"),
(7, "harsh","tintin"),(8, "shivtej", "sql_book"),
(9, "shivam", "java_book"),(10, "swaraj","python_book");

INSERT INTO `library_schema`.`library_table`
(`book_id`,
`book_name`,
`student_provided`)
VALUES
(1, "physics", "mohnish"),(2,"chemistry", "shubham"),
(3, "maths", "sumit"),(4,"harry_potter", "tanmay"),
(5, "marvel", "vikram"),(6,"dc", "sahil"),
(7,"tintin", "harsh"),(8, "sql_book", "shivtej"),
(9, "java_book", "shivam"),(10,"python_book", "swaraj");

SELECT * FROM  `library_schema`.`library_student_table` as student
join  `library_schema`.`library_table` as book 
ON student.library_student_book_borrowed = book.book_name;

select distinct * from library_table;

select distinct book_id from (select book_id from library_table union all select student_id from student) a order by book_id;

select distinct book_id from library join student on library.issue_no=student.issue_no order by book_id;
