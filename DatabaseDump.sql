




-- CREATE TABLE DividendRecords (
--     DividendId INT AUTO_INCREMENT PRIMARY KEY,
--     StockName VARCHAR(100),
--     DividendReceivedPerStock DECIMAL(10, 4),
--     NoOfShares DECIMAL(10, 4),
--     TotalAmount DECIMAL(10, 4) GENERATED ALWAYS AS (DividendReceivedPerStock * NoOfShares) STORED,
--     ReceivedDate DATETIME,
--     MemberId VARCHAR(50)
-- );

-- SAMPLE DATA **************************************

-- INSERT INTO DividendRecords (StockName, DividendReceivedPerStock, NoOfShares, ReceivedDate, MemberId)
-- VALUES ('SPYI', .5047, 5.4046, '2023-07-28 14:30:00', 'Bha2712');

-- INSERT INTO DividendRecords (StockName, DividendReceivedPerStock, NoOfShares, ReceivedDate, MemberId)
-- VALUES ('MPW', .29,153.12, '2023-07-13 14:30:00', 'Bha2712');


-- SELECT queries

-- Use stocks;

-- SELECT * FROM stocks.StockPositions;

SELECT * FROM DividendRecords;

-- DROP TABLE dividend_records;