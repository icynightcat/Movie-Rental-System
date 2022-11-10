--Table creation script for 291 project.
--	Database contains tables that represent a fictional "Blockbuster" style movie rental service. 
-- Assumes that database is called "movies"
use movies;


--Actors(actor_id, first_name, last_name, gender, age)
--a) actor_id is the primary key
CREATE TABLE Actors (
	actor_id INT NOT NULL,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	gender VARCHAR(10) NOT NULL,
	age INT NOT NULL,
	PRIMARY KEY (actor_id),
	);

--Movie(movie_id, movie_name, distribution_fee)
--a) movie_id is the primary key
CREATE TABLE Movie (
	movie_id INT NOT NULL,
	movie_name VARCHAR(50) NOT NULL,
	distribution_fee DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (movie_id)
	);

--Movie_copies(copy_id, movie_id, format, resolution)
--a) movie_id FK references Movie
--b) copy_id is the primary key
CREATE TABLE Movie_copies (
	copy_id INT NOT NULL,
	movie_id INT NOT NULL,
	format VARCHAR(50) NOT NULL,
	resolution VARCHAR(50) NOT NULL,
	PRIMARY KEY (copy_id),
	FOREIGN KEY (movie_id) REFERENCES Movie(movie_id)
	);

--Plan(plan_number, max_concurrent, max_monthly, cost)
--a) plan_number is the primary key
CREATE TABLE Plans (
	plan_number INT NOT NULL,
	max_concurrent INT NOT NULL,
	max_monthly INT NOT NULL,
	cost DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (plan_number)
	);

--Employees(employee_id, social_insurance_number, first_name, last_name, address, city, state,
--zip_code, telephone, start_date, hourly_rate)
--a) employee_id is the primary key
--b) social_insurance_number is unique
CREATE TABLE Employees (
	employee_id INT NOT NULL,
	social_insurance_number VARCHAR(50) NOT NULL,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	address VARCHAR(50) NOT NULL,
	city VARCHAR(50) NOT NULL,
	state VARCHAR(50) NOT NULL,
	zip_code VARCHAR(50) NOT NULL,
	telephone VARCHAR(50) NOT NULL,
	start_date DATE NOT NULL,
	hourly_rate DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (employee_id),
	UNIQUE (social_insurance_number)
	);

--Acts_in(actor_id, movie_id)
--a) actor_id, FK of Actors
--b) movie_id, FK of Movie
CREATE TABLE Acts_in (
	actor_id INT NOT NULL,
	movie_id INT NOT NULL,
	PRIMARY KEY (actor_id, movie_id),
	FOREIGN KEY (actor_id) REFERENCES Actors(actor_id),
	FOREIGN KEY (movie_id) REFERENCES Movie(movie_id)
	);

--Customer(account_number, first_name, last_name, address, city, state, zip_code, telephone,
--email, create_cust_date, account_type, credit_card, plan_number, start_date, end_date,
--customer_rating)
--a) plan_number FK references Plan
--b) account_number is the primary key
CREATE TABLE Customer (
	account_number INT NOT NULL,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	address VARCHAR(50) NOT NULL,
	city VARCHAR(50) NOT NULL,
	state VARCHAR(50) NOT NULL,
	zip_code VARCHAR(50) NOT NULL,
	telephone VARCHAR(50) NOT NULL,
	email VARCHAR(50) NOT NULL,
	create_cust_date DATE NOT NULL,
	account_type VARCHAR(50) NOT NULL,
	credit_card VARCHAR(50) NOT NULL,
	plan_number INT NOT NULL,
	start_date DATE NOT NULL,
	end_date DATE NOT NULL,
	customer_rating VARCHAR(50) NOT NULL,
	PRIMARY KEY (account_number),
	FOREIGN KEY (plan_number) REFERENCES Plans(plan_number)
	);

	--Types(type_of_movie)
--a) type_of_movie is the primary key
CREATE TABLE Types (
	type_of_movie VARCHAR(50) NOT NULL,
	PRIMARY KEY (type_of_movie)
	);


--Movie_type(movie_id, type_of_movie)
--a) type_of_movie, FK references Types
CREATE TABLE Movie_type (
	type_id INT NOT NULL,
	type_of_movie VARCHAR(50) NOT NULL,
	PRIMARY KEY (type_id),
	FOREIGN KEY (type_of_movie) REFERENCES Types(type_of_movie)
	);

--Order(order_id, movie_id, copy_id, order_placed_time, start_datetime, end_datetime,
--account_number, movie_rating, employee_id)
--a) movie_id FK references Movie
--b) copy_id FK references Movie_copies
--c) account_number FK references Customer
--d) Employee_id FK references Employees

create table Orders (
	order_id int not null,
	movie_id int not null,
	copy_id int not null,
	order_placed_time datetime not null,
	start_datetime datetime not null,
	end_datetime datetime not null,
	account_number int not null,
	movie_rating varchar(5) not null,
	employee_id int not null,
	primary key (order_id),
	foreign key (movie_id) references movie(movie_id),
	foreign key (copy_id) references movie_copies(copy_id),
	foreign key (account_number) references customer(account_number),
	foreign key (employee_id) references employees(employee_id)
);

--Movie_has_type(movie_id, type_id)
--a) movie_id FK references Movie
--b) type_id FK references Movie_type
CREATE TABLE Movie_has_type (
	movie_id INT NOT NULL,
	type_id INT NOT NULL,
	FOREIGN KEY (movie_id) REFERENCES Movie(movie_id),
	FOREIGN KEY (type_id) REFERENCES Movie_type(type_id)
	);