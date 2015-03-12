

-- Database and permissions setup

drop database if exists "LU.ENGI3675.Proj2";

-- Continue

drop role if exists "DynamicTable";
create role "DynamicTable" login;
comment on role "DynamicTable" is 'Restricted IIS app pool user';

-- Run Create Separately
create database "LU.ENGI3675.Proj2";

-- Continue
comment on database "LU.ENGI3675.Proj2" is 'Database for ENGI3675 Project 2';

grant connect on database "LU.ENGI3675.Proj2" to "DynamicTable";
grant connect on database "LU.ENGI3675.Proj2" to "postgres";


-- Table setup

drop table if exists Animals Cascade;

create table Animals (
	Serial_Number serial primary key,
	Breed text not null check (length(Breed)>0),
	Weight real not null check (Weight > 0 AND Weight < 500),
	Age real not null check (Age > 0 AND Age < 100)
);

grant select, insert, update, delete on table Animals to "DynamicTable";
grant select, insert, update, delete on table Animals to "postgres";
