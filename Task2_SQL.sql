create table product (product_id int identity(1,1) primary key, name varchar(255));
insert into product(name) values("car");
insert into product(name) values("bicycle");
insert into product(name) values("soap");
insert into product(name) values("phone");
insert into product(name) values("pasta");
insert into product(name) values("salsa");

create table category (category_id int identity(1,1) primary key, name varchar(255));
insert into category(name) values("vehicle");   -- here goes car and also bicycle
insert into category(name) values("food");      -- pasta and salsa
insert into category(name) values("bluetooth"); -- car and phone

-- having many-to-many relation poses need to have the third table
create table product_category (product_id int, category_id int, primary key(product_id, category_id));
insert into product_category(product_id, category_id) values(1,1);
insert into product_category(product_id, category_id) values(2,1);
insert into product_category(product_id, category_id) values(5,2);
insert into product_category(product_id, category_id) values(6,2);
insert into product_category(product_id, category_id) values(1,3);
insert into product_category(product_id, category_id) values(4,3);

-- so car has two categories and soap has none

select
    product.name, coalesce(category.name, "") as category_name_if_any
from
    product
        left join
    product_category
        on product.product_id = product_category.product_id
        left join
    category
        on category.category_id = product_category.category_id;

