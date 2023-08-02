




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

-- 2023 DIVIDEND RECORDS ON ROBINHOOD -- REMEMBER to not add pending dividends
-- INSERT INTO DividendRecords (StockName, DividendReceivedPerStock, NoOfShares, ReceivedDate, MemberId) VALUES
-- ('AAPL', 0.23, 2.0175, '2023-02-16', 'Bha2712'),
-- ('MSFT', 0.68, 4.0538, '2023-03-09', 'Bha2712'),
-- ('DRN', 0.094, 9, '2023-03-28', 'Bha2712'),
-- ('VOO', 1.49, 1.0091, '2023-03-29', 'Bha2712'),
-- ('JEPI', 0.4246, 11.9677, '2023-05-04', 'Bha2712'),
-- ('AAPL', 0.24, 2.0205, '2023-05-18', 'Bha2712'),
-- ('JEPI', 0.3654, 12.792, '2023-06-06', 'Bha2712'),
-- ('MSFT', 4.0648, 0.68, '2023-06-08', 'Bha2712'),
-- ('XLV', 0.5424, 0.229, '2023-06-23', 'Bha2712'),
-- ('SCHD', 0.6647, 4.8127, '2023-06-26', 'Bha2712'),
-- ('DRN', 0.0726, 9.0995, '2023-06-28', 'Bha2712'),
-- ('VOO', 1.58, 1.0131, '2023-07-05', 'Bha2712'),
-- ('JEPI', 0.3593, 13.152, '2023-07-07', 'Bha2712'),
-- ('HIMX', 0.47, 400, '2023-07-12', 'Bha2712'),
-- ('MPW', 0.29, 153.1246, '2023-07-13', 'Bha2712'),
-- ('SPYI', 0.5047, 5.4046, '2023-07-28', 'Bha2712');


-- SELECT queries

-- Use stocks;

-- SELECT * FROM stocks.StockPositions;

SELECT * FROM DividendRecords;

-- DROP TABLE dividend_records;