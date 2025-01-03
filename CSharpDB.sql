Create database CSharp
go 
using CSharp

CREATE TABLE [dbo].[Users] (
    [userID]       INT           IDENTITY (1, 1) NOT NULL,
    [userName]     NVARCHAR (50) NOT NULL,
    [userPassword] NVARCHAR (30) NOT NULL,
    [email]        NVARCHAR (50) NOT NULL,
    [age]          INT           NULL,
    [balance]      FLOAT (53)    NULL,
    [role]         NVARCHAR (20) NOT NULL,
    [isBanned]     BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([userID] ASC),
    UNIQUE NONCLUSTERED ([email] ASC, [userName] ASC, [userPassword] ASC),
    CONSTRAINT [chk_role] CHECK ([role]='publisher' OR [role]='customer' OR [role]='admin')
);

INSERT INTO Users (userName, userPassword, email, age, balance, role, isBanned)
VALUES ('Naughty Dog LLC', '123456', 'NGL@gmail.com', 22, 0, 'publisher', 0);

CREATE TABLE [dbo].[CartGames] (
    [CartID]   INT NOT NULL,
    [GameID]   INT NOT NULL,
    [Quantity] INT NULL,
    PRIMARY KEY CLUSTERED ([CartID] ASC, [GameID] ASC),
    FOREIGN KEY ([CartID]) REFERENCES [dbo].[Carts] ([CartID]),
    FOREIGN KEY ([GameID]) REFERENCES [dbo].[Games] ([GameID])
);

CREATE TABLE [dbo].[Carts] (
    [CartID] INT IDENTITY (1, 1) NOT NULL,
    [UserID] INT NULL,
    PRIMARY KEY CLUSTERED ([CartID] ASC),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([userID])
);

CREATE TABLE [dbo].[Games] (
    [GameID]      INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (100) NOT NULL,
    [Detail]      NVARCHAR (MAX) NULL,
    [Price]       FLOAT (53)     NOT NULL,
    [PublisherID] INT            NOT NULL,
    [UrlPoster]   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([GameID] ASC)
);

INSERT INTO Games (Title, Detail, Price, PublisherID, UrlPoster)
VALUES 
('The Last of Us™', 'Khám phá trò chơi từng đoạt giải thưởng, đã truyền cảm hứng cho chương trình truyền hình được đánh giá cao. Dẫn đường cho Joel và Ellie qua nước Mỹ hậu tận thế và gặp gỡ những đồng minh và kẻ thù khó quên trong The Last of Us™.', 1000000, 1, 'C:\Users\Admin\source\repos\BaoCAo\BaoCAo\Resources\Video_Game_Cover_The_Last_of_Us.jpg'),
('Uncharted 4: A Thief''s End', 'Nhập vai Nathan Drake và Chloe Frazer trong chuyến phiêu lưu của riêng họ khi đối mặt với quá khứ và tạo nên di sản cho mình. Trò chơi gồm phần chơi đơn với cốt truyện được giới phê bình đánh giá cao trong cả UNCHARTED 4: A Thief’s End và UNCHARTED: The Lost Legacy.', 120000, 1, 'C:\Users\Admin\source\repos\BaoCAo\BaoCAo\Resources\Uncharted-4-A-Thiefs-End-PS4.jpg');


CREATE TABLE [dbo].[GameUsers] (
    [GameID] INT NOT NULL,
    [UserID] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([GameID] ASC, [UserID] ASC),
    FOREIGN KEY ([GameID]) REFERENCES [dbo].[Games] ([GameID]),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([userID])
);

CREATE TABLE [dbo].[Genres] (
    [GenreID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([GenreID] ASC)
);

INSERT INTO Genres (Name) VALUES ('Action'),('Survival'),('Cinematic')
                                ,('Adventure'),('Drama'),('Story Rich')
                                ,('Horror'),('Puzzle'),('Shooter')
                                ,('Parkour'),('Stealth'),('Combat');

CREATE TABLE [dbo].[Libraries] (
    [LibraryID] INT IDENTITY (1, 1) NOT NULL,
    [UserID]    INT NULL,
    PRIMARY KEY CLUSTERED ([LibraryID] ASC),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([userID])
);

CREATE TABLE [dbo].[LibraryGames] (
    [LibraryID] INT      NOT NULL,
    [GameID]    INT      NOT NULL,
    [DateAdded] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([LibraryID] ASC, [GameID] ASC),
    FOREIGN KEY ([LibraryID]) REFERENCES [dbo].[Libraries] ([LibraryID]),
    FOREIGN KEY ([GameID]) REFERENCES [dbo].[Games] ([GameID])
);

CREATE TABLE [dbo].[WishlistGames] (
    [WishlistID] INT      NOT NULL,
    [GameID]     INT      NOT NULL,
    [DateAdded]  DATETIME NULL,
    PRIMARY KEY CLUSTERED ([WishlistID] ASC, [GameID] ASC),
    FOREIGN KEY ([WishlistID]) REFERENCES [dbo].[Wishlists] ([WishlistID]),
    FOREIGN KEY ([GameID]) REFERENCES [dbo].[Games] ([GameID])
);

CREATE TABLE [dbo].[Wishlists] (
    [WishlistID] INT IDENTITY (1, 1) NOT NULL,
    [UserID]     INT NULL,
    PRIMARY KEY CLUSTERED ([WishlistID] ASC),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([userID])
);

CREATE TABLE [dbo].[GenreGame] (
    [GenreGameID] INT IDENTITY (1, 1) NOT NULL,
    [GenreID]     INT NOT NULL,
    [GameID]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([GenreGameID] ASC),
    UNIQUE NONCLUSTERED ([GenreID] ASC, [GameID] ASC),
    FOREIGN KEY ([GenreID]) REFERENCES [dbo].[Genres] ([GenreID]),
    FOREIGN KEY ([GameID]) REFERENCES [dbo].[Games] ([GameID])
);

INSERT INTO GenreGame (GenreID, GameID) VALUES (4, 2),(1, 2),(6, 2),(8, 2)
                                              ,(9, 2),(11, 2),(12, 2),(6, 1)
                                              ,(9, 1),(13, 1),(7, 1),(2, 1)
                                              ,(1, 1),(5, 1),(4, 1),(3, 1);

CREATE TABLE Comments (
    CommentID INT PRIMARY KEY IDENTITY(1,1),
    GameID INT NOT NULL,
    UserID INT NOT NULL,
    CommentText NVARCHAR(MAX) NOT NULL,
    CommentDate DATETIME NOT NULL,
    FOREIGN KEY (GameID) REFERENCES Games(GameID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
CREATE TABLE Comments (
    CommentID INT PRIMARY KEY IDENTITY(1,1),
    GameID INT NOT NULL,
    UserID INT NOT NULL,
    CommentText NVARCHAR(MAX) NOT NULL,
    CommentDate DATETIME NOT NULL,
    FOREIGN KEY (GameID) REFERENCES Games(GameID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
alter table Users
add urlAvatar nvarchar(max)

alter table Users
add urlTheme nvarchar(max)
