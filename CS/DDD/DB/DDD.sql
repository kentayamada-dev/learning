CREATE TABLE User(
    id              INTEGER     PRIMARY KEY AUTOINCREMENT,
    name            TEXT        NOT NULL UNIQUE,
	password        TEXT        NOT NULL,
    createdAt       TEXT        NOT NULL DEFAULT (DATETIME('now', 'localtime')),
    updatedAt       TEXT        NOT NULL DEFAULT (DATETIME('now', 'localtime')),
	CHECK(LENGTH(name) >= 5 AND LENGTH(name) <= 10)
	CHECK(LENGTH(password) >= 5 AND LENGTH(password) <= 10)
) STRICT;

CREATE TABLE Weather(
	zipCode         TEXT,
	measuredDate	TEXT,
	condition	    TEXT        NOT NULL COLLATE BINARY,
	temperature     REAL        NOT NULL,
	userId          INTEGER,
	PRIMARY KEY(zipCode, measuredDate)
    FOREIGN KEY(zipCode)        REFERENCES Area(zipCode)
	FOREIGN KEY(userId)         REFERENCES User(id),
	CHECK(measuredDate IS DATETIME(measuredDate))
	CHECK(condition = 'SUNNY' OR condition = 'CLOUDY' OR condition = 'RAINY' OR condition = 'UNKNOWN')
) STRICT;

CREATE TABLE Area(
	zipCode	        TEXT,
	stateAbbr	    TEXT        UNIQUE,
	PRIMARY KEY(zipCode)
	CHECK(zipCode GLOB '[0-9][0-9][0-9][0-9][0-9]')
	CHECK(stateAbbr GLOB '[A-Z][A-Z]')
) STRICT;

CREATE TRIGGER user_updated_trigger AFTER UPDATE ON User
BEGIN
    UPDATE User SET updatedAt = DATETIME('now', 'localtime') WHERE rowid == NEW.rowid;
END;

PRAGMA foreign_keys=true;

INSERT INTO User(name, password) VALUES('aaaaa', 'aaaaa'), ('sssss', 'sssss'), ('zzzzz', 'zzzzz'), ('xxxxx', 'xxxxx');

INSERT INTO Area(zipCode, stateAbbr) VALUES('35004', 'AL'), ('90001', 'CA'), ('32003', 'FL'), ('22003', 'NY');

INSERT INTO Weather(zipCode, measuredDate, condition, temperature, userId)
VALUES
	('35004', '2018-08-10 11:10:10', 'SUNNY',   31,    1),
	('35004', '2018-08-11 12:10:10', 'CLOUDY',  30.2,  2),
	('90001', '2018-08-11 13:10:10', 'RAINY',   24.3,  3),
    ('32003', '2018-08-12 14:10:10', 'UNKNOWN', 24.12, 3);
