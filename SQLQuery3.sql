CREATE DATABASE bankSystem;


CREATE TABLE bank(
  code INT NOT NULL,
  name VARCHAR(50),
  address VARCHAR(30),
  PRIMARY KEY(code)
);

CREATE TABLE branch(
   bnum INT NOT NULL,
   address VARCHAR(30),
   code INT NOT NULL,
   PRIMARY KEY (bnum),
   FOREIGN KEY (code) REFERENCES bank(code)
)

CREATE TABLE customer(
   SSN INT NOT NULL,
   name VARCHAR(25),
   phone_num VARCHAR(11),
   address VARCHAR(30),
   bnum INT ,
   PRIMARY KEY (SSN),
   FOREIGN KEY (bnum) REFERENCES branch(bnum)
)





CREATE TABLE accounts(
   anum INT NOT NULL,
   balance BIGINT NOT NULL,
   type VARCHAR(20),
)

CREATE TABLE customer_loan(
   SSN INT NOT NULL,
   lnum INT NOT NULL,
   PRIMARY KEY(SSN,lnum)
)

CREATE TABLE customer_accounts(
   SSN INT NOT NULL,
   anum INT NOT NULL,
   PRIMARY KEY(SSN,anum)
)


CREATE TABLE employee(
   ID int NOT NULL,
   name VARCHAR(15) NOT NULL,
   salary INT NOT NULL,
   bnum int ,
   PRIMARY KEY (ID),
   FOREIGN KEY (bnum) REFERENCES branch(bnum) 
)
CREATE TABLE loan(
   lnum int NOT NULL,
   type VARCHAR(15) NOT NULL,
   amount BIGINT NOT NULL,
   bnum INT,
   employee_ID INT,
   PRIMARY KEY (lnum),
   FOREIGN KEY (bnum) REFERENCES branch(bnum),
   FOREIGN KEY (employee_ID) REFERENCES employee(ID)

)
CREATE TABLE employeee(
   ID int NOT NULL,
   name VARCHAR(15) NOT NULL,
   salary INT NOT NULL,
   PRIMARY KEY (ID),
)