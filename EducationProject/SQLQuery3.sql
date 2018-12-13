create table Login(
LoginId int not null primary key identity(1,1),
LoginEmail nvarchar(50) not null,
LoginPassword nvarchar(50) not null,
UserTypeId  int not null,
 CONSTRAINT FK_UserType FOREIGN KEY (UserTypeId)
    REFERENCES UserType(UserTypeId)
)