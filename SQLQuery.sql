-- CREATINGG TABLES
-- Create tb_admin table
CREATE TABLE tb_admin (
    id_admin INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255),
    email VARCHAR(255),
    password VARCHAR(255)
);

-- Create tb_recipe table
CREATE TABLE tb_recipe (
    id_recipe INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255),
    thumbnail VARCHAR(255),
    description TEXT,
    created_at DATETIME,
    id_admin INT FOREIGN KEY REFERENCES tb_admin(id_admin),
    rating FLOAT
);

-- Create tb_member table
CREATE TABLE tb_member (
    id_member INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255),
    email VARCHAR(255),
    password VARCHAR(255)
);

-- Create tb_comment table
CREATE TABLE tb_comment (
    id_comment INT PRIMARY KEY IDENTITY(1,1),
    id_member INT FOREIGN KEY REFERENCES tb_member(id_member),
    id_recipe INT FOREIGN KEY REFERENCES tb_recipe(id_recipe),
    comment TEXT,
    rating INT,
    created_at DATETIME
);

-- Create tb_loved table
CREATE TABLE tb_loved (
    id_member INT FOREIGN KEY REFERENCES tb_member(id_member),
    id_recipe INT FOREIGN KEY REFERENCES tb_recipe(id_recipe),
    loved_at DATETIME,
    PRIMARY KEY (id_member, id_recipe)
);

--INSERTING VALUES
--Insert tb_admin
INSERT INTO tb_admin values ('admin1', 'admin1@gmail.com', 'admin1');
