CREATE TABLE pdc
(
    numero INT NOT NULL PRIMARY KEY,
    dtsolicit DATE NOT NULL,
    hrsolicit TIME NOT NULL,
    dtlimite DATE NOT NULL,
    hrlimite TIME NOT NULL,
    dtimpressao DATETIME NOT NULL,
    cliente VARCHAR(15) NOT NULL,
    localcoleta TEXT NOT NULL
);

SELECT * FROM pdc;