--USE goatstore;
--go

DROP TABLE [dbo].[products];
go

CREATE TABLE [dbo].[products] (
    [id] int IDENTITY(1,1) PRIMARY KEY,
    [name] varchar(255),
    [description] varchar(255),
    [image] varchar(255)
);
go

INSERT INTO products ([name], [description], [image])
    VALUES ('Frisky Tom', 'A nice goat, likes jumping about and occasionally skipping', 'https://images.unsplash.com/photo-1524024973431-2ad916746881?w=800');
INSERT INTO products ([name], [description], [image])
    VALUES ('Grumpy Bob', 'A grumpy old sod, smells bad but he means well', 'https://media.mnn.com/assets/images/2016/07/closeup-black-goat-eyes.jpg.838x0_q80.jpg');
INSERT INTO products ([name], [description], [image])
    VALUES ('Lucky Emma', 'She likes listening to death metal and Taylor Swift' , 'https://upload.wikimedia.org/wikipedia/commons/d/d2/Brown_female_goat.jpg');
INSERT INTO products ([name], [description], [image])
    VALUES ('Hungry Dave', 'Dave likes to eat stuff, that''s his favourite thing', 'https://images.pexels.com/photos/144240/goat-lamb-little-grass-144240.jpeg');
go