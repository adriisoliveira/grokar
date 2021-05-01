use SoftwareGrokar

create table UsersLogin(
	ID int primary key NOT NULL,
	UserName varchar(10) NOT NULL,
	PasswordUser varchar(12) NOT NULL
)

insert UsersLogin values(1,'adrianne','123456');

select * from UsersLogin