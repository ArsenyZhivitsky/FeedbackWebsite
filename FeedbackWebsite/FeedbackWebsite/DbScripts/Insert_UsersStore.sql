--declaring variables
declare @userName nvarchar(20) = 'admin@gmail.com'
declare @passwordHash nvarchar(100) = ''
declare @userId nvarchar(100)
declare @roleId nvarchar(100)

--Inserting user and admin roles
insert into [UsersStore].[dbo].[AspNetRoles]
values (LOWER(NEWID()), 'admin', 'ADMIN', LOWER(NEWID())),
(LOWER(NEWID()), 'user', 'USER', LOWER(NEWID()))

--Inserting new admin user
insert into [UsersStore].[dbo].[AspNetUsers]
values (LOWER(NEWID()), @userName, UPPER(@userName), @userName, UPPER(@userName), 1, @passwordHash, LOWER(NEWID()), LOWER(NEWID()), null, 0, 0, null, 1, 0, 'Admin', 'Admin', 'Admin')

--Insering new userRole relation
set @userId = (select [Id] from [UsersStore].[dbo].[AspNetUsers] where UserName = @userName)
set @roleId = (select [Id] from [UsersStore].[dbo].[AspNetRoles] where [Name] = 'admin')

insert into [UsersStore].[dbo].[AspNetUserRoles]
values (@userId, @roleId)