CREATE TABLE Weather (
	zipCode         TEXT,
	measuredDate	TEXT,
	condition	    TEXT        COLLATE BINARY NOT NULL,
	temperature     REAL        NOT NULL,
	PRIMARY KEY(zipCode, measuredDate)
    FOREIGN KEY(zipCode)        REFERENCES Area(zipCode)
	CHECK(measuredDate IS DATETIME(measuredDate))
	CHECK (condition = "SUNNY" OR condition = "CLOUDY" OR condition = "RAINY" OR condition = "UNKNOWN")
) STRICT;

CREATE TABLE Area (
	zipCode	        TEXT,
	stateAbbr	    TEXT        UNIQUE NOT NULL,
	PRIMARY KEY(zipCode)
	CHECK(zipCode GLOB '[0-9][0-9][0-9][0-9][0-9]')
	CHECK(stateAbbr GLOB '[A-Z][A-Z]')
) STRICT;

PRAGMA foreign_keys=true;

INSERT INTO Area(zipCode, stateAbbr) VALUES("35004", "AL"), ("90001", "CA"), ("32003", "FL"), ("22003", "NY");

INSERT INTO Weather(zipCode, measuredDate, condition, temperature)
VALUES
	("35004", "2018-08-10 11:10:10", "SUNNY",   31),
	("35004", "2018-08-11 12:10:10", "CLOUDY",  30.2),
	("90001", "2018-08-11 13:10:10", "RAINY",   24.3),
    ("32003", "2018-08-12 14:10:10", "UNKNOWN", 24);
