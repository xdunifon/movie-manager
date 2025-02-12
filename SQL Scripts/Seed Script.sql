-- Seed Genres
INSERT INTO Genres (Id, Name) VALUES
(1, 'Action'),
(2, 'Comedy'),
(3, 'Drama'),
(4, 'Horror'),
(5, 'Sci-Fi');

-- Seed Movies
INSERT INTO Movies (Id, Active, DateCreated, DateModified, Name, Description, GenreId, Duration, DateReleased) VALUES
(1, 1, '2025-01-01 12:00:00', '2025-01-01 12:00:00', 'The Great Adventure', 'An action-packed journey.', 1, 120, '2025-02-15'),
(2, 1, '2025-01-02 12:00:00', '2025-01-02 12:00:00', 'Laugh Out Loud', 'A comedy about the ups and downs of life.', 2, 90, '2025-03-01'),
(3, 1, '2025-01-03 12:00:00', '2025-01-03 12:00:00', 'Tears of the Heart', 'A touching drama.', 3, 105, '2025-04-10');

-- Seed Persons
INSERT INTO Person (Id, Active, DateCreated, DateModified, Name, DateBorn) VALUES
(1, 1, '2025-01-01 12:00:00', '2025-01-01 12:00:00', 'John Smith', '1980-05-20'),
(2, 1, '2025-01-02 12:00:00', '2025-01-02 12:00:00', 'Jane Doe', '1990-08-15'),
(3, 1, '2025-01-03 12:00:00', '2025-01-03 12:00:00', 'Mike Johnson', '1975-12-05');

-- Seed CrewRoles
INSERT INTO CrewRoles (Id, Active, DateCreated, DateModified, Name) VALUES
(1, 1, '2025-01-01 12:00:00', '2025-01-01 12:00:00', 'Director'),
(2, 1, '2025-01-02 12:00:00', '2025-01-02 12:00:00', 'Actor'),
(3, 1, '2025-01-03 12:00:00', '2025-01-03 12:00:00', 'Producer');

-- Seed CrewMembers
INSERT INTO CrewMembers (Id, Active, DateCreated, DateModified, MovieId, PersonId, RoleId) VALUES
(1, 1, '2025-01-01 12:00:00', '2025-01-01 12:00:00', 1, 1, 1),
(2, 1, '2025-01-02 12:00:00', '2025-01-02 12:00:00', 1, 2, 2),
(3, 1, '2025-01-03 12:00:00', '2025-01-03 12:00:00', 2, 3, 1);

-- Seed Users
INSERT INTO Users (Id, Active, DateCreated, DateModified, Name, DateBorn) VALUES
(1, 1, '2025-01-01 12:00:00', '2025-01-01 12:00:00', 'Alice Johnson', '1995-07-10'),
(2, 1, '2025-01-02 12:00:00', '2025-01-02 12:00:00', 'Bob Williams', '1988-03-25');

-- Seed Reviews
INSERT INTO Reviews (Id, Active, DateCreated, DateModified, Subject, Content, Rating, MovieId, UserId) VALUES
(1, 1, '2025-01-05 12:00:00', '2025-01-05 12:00:00', 'Amazing!', 'Loved every moment of it.', 5, 1, 1),
(2, 1, '2025-01-06 12:00:00', '2025-01-06 12:00:00', 'Not Bad', 'It was okay.', 3, 2, 2);

-- Seed MoviePlaylists
INSERT INTO MoviePlaylists (Id, Name, CreatorId) VALUES
(1, 'Action Favorites', 1),
(2, 'Comedy Gold', 2);

-- Seed MovieToPlaylists
INSERT INTO MovieToPlaylists (Id, MovieId, PlaylistId) VALUES
(1, 1, 1),
(2, 2, 2);
