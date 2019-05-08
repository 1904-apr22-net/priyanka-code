CREATE DATABASE MovieDb;
GO
CREATE SCHEMA Movie;
GO
CREATE TABLE Movie.Movie (
	-- list of columns, constraints, etc.
	-- each column: name, and then type, and then contraints
	MovieId INT NOT NULL
);

SELECT * FROM Movie.Movie;
ALTER TABLE Movie.Movie ADD
	Title NVARCHAR(200) NOT NULL;

	DROP TABLE Movie.Movie;
	CREATE TABLE Movie.Movie (
	MovieId INT NOT NULL IDENTITY,
	Title NVARCHAR(200) NOT NULL,
	ReleaseDate DATE NOT NULL,
	DateModified DATETIME2 NOT NULL DEFAULT(GETDATE()),
	Active BIT NOT NULL DEFAULT(1),
	CONSTRAINT PK_MovieId PRIMARY KEY (MovieId),
	CONSTRAINT U_Title_ReleaseDate UNIQUE (Title, ReleaseDate),
	CONSTRAINT CK_DateNotTooEarly CHECK (ReleaseDate > '1900')
);
INSERT INTO Movie.Movie (Title, ReleaseDate) VALUES
	('Avengers: Endgame', '2019');
	INSERT INTO Movie.Movie (MovieId, Title, ReleaseDate) VALUES
	(8, 'asdf', '1019');
	CREATE TABLE Movie.Genre (
	GenreId INT NOT NULL IDENTITY,
	Name NVARCHAR(100) NOT NULL UNIQUE,
	DateModified DATETIME2 NOT NULL DEFAULT(GETDATE()),
	Active BIT NOT NULL DEFAULT(1)
);
ALTER TABLE Movie.Genre ADD
	CONSTRAINT PK_GenreId PRIMARY KEY (GenreId);
	INSERT INTO Movie.Genre (Name) VALUES
	('Action');
	ALTER TABLE Movie.Movie ADD
	GenreId INT NOT NULL DEFAULT(1),
	CONSTRAINT FK_Movie_Genre FOREIGN KEY (GenreId)
		REFERENCES Movie.Genre (GenreId)
		ON DELETE CASCADE;
		ALTER TABLE Movie.Movie DROP
	CONSTRAINT DF__Movie__GenreId__5535A963;
	ALTER TABLE Movie.Movie ADD
	FullName AS (Title + ' (' + CONVERT(NVARCHAR, YEAR(ReleaseDate)) + ')');
	SELECT * FROM Movie.Movie;
	GO
CREATE VIEW Movie.NewReleases AS
	SELECT * FROM Movie.Movie
	WHERE DATEDIFF(MONTH, ReleaseDate, GETDATE()) < 6;
GO
SELECT * FROM Movie.NewReleases;
INSERT INTO Movie.Movie (Title, ReleaseDate, GenreId) VALUES
	('Avengers: Infinity War', '2018', 1);
	SELECT * FROM Movie.NewReleases;
	SELECT * FROM Movie.Movie;
	DECLARE @numberofmonths AS INT;
	SET @numberofmonths = 6;
	DECLARE @my_table AS TABLE ( col1 INT, col2 INT );
	INSERT INTO @my_table VALUES (4, 5);
	SELECT * FROM @my_table;
	GO
CREATE FUNCTION Movie.MoviesReleasedInYear(@year INT)
RETURNS INT
AS
BEGIN
	DECLARE @result INT;

	SELECT @result = COUNT(*)
	FROM Movie.Movie
	WHERE YEAR(ReleaseDate) = @year;

	RETURN @result;
END
GO
SELECT Movie.MoviesReleasedInYear(2018);
GO
CREATE FUNCTION Movie.AllMoviesReleasedInYear(@year INT)
RETURNS TABLE
AS
	RETURN (
		SELECT *
		FROM Movie.Movie
		WHERE YEAR(ReleaseDate) = @year
	);

GO
SELECT * FROM Movie.AllMoviesReleasedInYear(2019);
GO
CREATE TRIGGER Movie.MovieDateModified ON Movie.Movie
AFTER UPDATE
AS
BEGIN
	-- inside the body here, we have access to two
	-- special table variables, Inserted and Deleted.
	UPDATE Movie.Movie
	SET DateModified = GETDATE()
	WHERE MovieId IN (SELECT MovieId FROM Inserted);
	-- Inserted has the new versions of the updated rows.
END

SELECT * FROM Movie.Movie;
UPDATE Movie.Movie
SET ReleaseDate = '2019-02-01'
WHERE MovieId = 1;
ALTER TABLE Movie.Movie ADD
	CONSTRAINT CK_NonEmptyTitle CHECK (Title != '');
	GO
--DROP PROCEDURE Movie.RenameAllMovies;
CREATE PROCEDURE Movie.RenameAllMovies(@newname NVARCHAR(50), @rowschanged INT OUTPUT)
AS
BEGIN
	-- we have access to a lot of control flow stuff
	IF EXISTS (SELECT * FROM Movie.Movie)
	BEGIN
		BEGIN TRY
			UPDATE Movie.Movie
			SET Title = @newname;
			SELECT @rowschanged = COUNT(*) FROM Movie.Movie;
		END TRY
		BEGIN CATCH
			PRINT 'Not allowed to do that!';
			PRINT ERROR_MESSAGE();
			SET @rowschanged = 0;
		END CATCH
	END
	ELSE
	BEGIN
		SET @rowschanged = 0;
		-- errors in SQL have some metadata to them, 
		RAISERROR('no movies found', 16, 1);
		--THROW 'no movies found', 16, 1;
	END
END
DECLARE @rowschanged INT;
EXECUTE Movie.RenameAllMovies 'Aasdf', @rowschanged;
SELECT @rowschanged;