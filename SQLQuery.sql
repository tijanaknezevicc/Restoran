create database restoran
use restoran

create table gost
(
	id int identity(1,1) primary key,
	ime nvarchar(30),
	prezime nvarchar(30),
	kontaktTelefon nvarchar(30),
	email nvarchar(30),
	pass nvarchar(30)
)

create table termin
(
	id int identity(1,1) primary key,
	datum date,
	vreme time
)

create table sto
(
	id int identity(1,1) primary key,
	kapacitet int
)

create table rezervacija
(
	id int identity(1,1) primary key,
	gostID int foreign key references gost(id),
	stoID int foreign key references sto(id),
	terminID int unique foreign key references termin(id)
)

select rezervacija.id, gost.ime + ' ' + gost.prezime as gost, sto.kapacitet as 'broj osoba', termin.vreme as vreme, termin.datum as datum
from rezervacija join gost on gost.id = gostID join sto on sto.id = stoID join termin on termin.id = terminID
where gostID = 2

insert into termin (datum, vreme)
values ('2022/12/11', '20:30')

select * from termin

insert into rezervacija (gostID, stoID, terminID)
values (1, 7, 8)

delete from rezervacija where id = 5

select * from rezervacija