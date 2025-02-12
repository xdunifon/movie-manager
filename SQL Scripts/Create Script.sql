CREATE TABLE Movies (
    Id INTEGER PRIMARY KEY,
    Active BOOLEAN,
    DateCreated DATETIME,
    DateModified DATETIME,
    Name TEXT,
    Description TEXT,
    GenreId INTEGER,
    Duration INTEGER,
    DateReleased DATE,
    FOREIGN KEY (GenreId) REFERENCES Genres(Id)
);

CREATE TABLE Genres (
    Id INTEGER PRIMARY KEY,
    Name TEXT
);

CREATE TABLE CrewMembers (
    Id INTEGER PRIMARY KEY,
    Active BOOLEAN,
    DateCreated DATETIME,
    DateModified DATETIME,
    MovieId INTEGER,
    PersonId INTEGER,
    RoleId INTEGER,
    FOREIGN KEY (MovieId) REFERENCES Movies(Id),
    FOREIGN KEY (PersonId) REFERENCES Person(Id),
    FOREIGN KEY (RoleId) REFERENCES CrewRoles(Id)
);

CREATE TABLE Person (
    Id INTEGER PRIMARY KEY,
    Active BOOLEAN,
    DateCreated DATETIME,
    DateModified DATETIME,
    Name TEXT,
    DateBorn DATE
);

CREATE TABLE CrewRoles (
    Id INTEGER PRIMARY KEY,
    Active BOOLEAN,
    DateCreated DATETIME,
    DateModified DATETIME,
    Name TEXT
);

CREATE TABLE Reviews (
    Id INTEGER PRIMARY KEY,
    Active BOOLEAN,
    DateCreated DATETIME,
    DateModified DATETIME,
    Subject TEXT,
    Content TEXT,
    Rating INTEGER,
    MovieId INTEGER,
    UserId INTEGER,
    FOREIGN KEY (MovieId) REFERENCES Movies(Id),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);

CREATE TABLE Users (
    Id INTEGER PRIMARY KEY,
    Active BOOLEAN,
    DateCreated DATETIME,
    DateModified DATETIME,
    Name TEXT,
    DateBorn DATE
);

CREATE TABLE MoviePlaylists (
    Id INTEGER PRIMARY KEY,
    Name TEXT,
    CreatorId INTEGER,
    FOREIGN KEY (CreatorId) REFERENCES Users(Id)
);

CREATE TABLE MovieToPlaylists (
    Id INTEGER PRIMARY KEY,
    MovieId INTEGER,
    PlaylistId INTEGER,
    FOREIGN KEY (MovieId) REFERENCES Movies(Id),
    FOREIGN KEY (PlaylistId) REFERENCES MoviePlaylists(Id)
);
