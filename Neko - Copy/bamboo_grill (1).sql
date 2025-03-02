-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 03, 2025 at 08:45 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bamboo_grill`
--

-- --------------------------------------------------------

--
-- Table structure for table `beverages`
--

CREATE TABLE `beverages` (
  `ItemID` int(11) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `QTY` int(11) NOT NULL,
  `Price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `coffees`
--

CREATE TABLE `coffees` (
  `ItemID` int(11) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `QTY` int(11) NOT NULL,
  `Price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CID` int(11) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) DEFAULT NULL,
  `PhoneNumber` varchar(15) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `TableNumber` int(11) DEFAULT NULL,
  `ItemsOrdered` varchar(255) DEFAULT NULL,
  `QTY` int(11) DEFAULT NULL,
  `TransactionType` enum('Dine-in','Take-out') NOT NULL,
  `OrderStatus` enum('Completed','Pending','Cancelled') NOT NULL,
  `TimeOrdered` datetime NOT NULL,
  `DateOrdered` date NOT NULL,
  `SubTotal` decimal(10,2) NOT NULL,
  `DiscountAmount` decimal(10,2) DEFAULT 0.00,
  `NetAmount` decimal(10,2) NOT NULL,
  `PaymentMethod` enum('Gcash','Cash') NOT NULL,
  `ReceiptNumber` varchar(50) NOT NULL,
  `RefundStatus` enum('Yes','No') NOT NULL DEFAULT 'No',
  `DateRecorded` datetime DEFAULT current_timestamp(),
  `ProcessedBy` enum('Admin','Cashier','Staff') NOT NULL,
  `Notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`CID`, `FirstName`, `LastName`, `PhoneNumber`, `Address`, `TableNumber`, `ItemsOrdered`, `QTY`, `TransactionType`, `OrderStatus`, `TimeOrdered`, `DateOrdered`, `SubTotal`, `DiscountAmount`, `NetAmount`, `PaymentMethod`, `ReceiptNumber`, `RefundStatus`, `DateRecorded`, `ProcessedBy`, `Notes`) VALUES
(1, 'Nico', 'Adlawan', '09915638939', 'Purok 4 Bagasbas DCN', 5, '1', 2, 'Dine-in', 'Completed', '2025-01-31 19:04:59', '2025-01-31', 300.00, 30.00, 270.00, 'Cash', 'RCPT12345', 'No', '2025-01-31 19:04:59', 'Cashier', 'Regular customer');

-- --------------------------------------------------------

--
-- Table structure for table `desserts`
--

CREATE TABLE `desserts` (
  `ItemID` int(11) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `QTY` int(11) NOT NULL,
  `Price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EID` int(11) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `MiddleName` varchar(100) DEFAULT NULL,
  `LastName` varchar(100) NOT NULL,
  `Role` enum('Cashier','Crew','Dishwasher','Griller','Cook') NOT NULL,
  `PhoneNumber` varchar(15) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Barangay` varchar(100) DEFAULT NULL,
  `City` varchar(100) DEFAULT NULL,
  `Province` varchar(100) DEFAULT NULL,
  `ZipCode` varchar(10) DEFAULT NULL,
  `ActiveEmployee` enum('Yes','No') NOT NULL DEFAULT 'Yes',
  `HireDate` date NOT NULL,
  `DateLeft` date DEFAULT NULL,
  `Notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EID`, `FirstName`, `MiddleName`, `LastName`, `Role`, `PhoneNumber`, `Email`, `Barangay`, `City`, `Province`, `ZipCode`, `ActiveEmployee`, `HireDate`, `DateLeft`, `Notes`) VALUES
(1, 'Jennie', 'Dado', 'Adlawan', 'Cashier', '09319193251', 'jennie030499@gmail.com', 'Bagasbas', 'Daet', 'Camarines Norte', '4600', 'Yes', '2025-01-31', NULL, 'Senior cashier');

-- --------------------------------------------------------

--
-- Table structure for table `expensesoverview`
--

CREATE TABLE `expensesoverview` (
  `ExID` int(11) NOT NULL,
  `Category` varchar(100) NOT NULL,
  `ItemID` int(11) DEFAULT NULL,
  `Qty` decimal(10,2) NOT NULL,
  `UnitOfMeasure` enum('kg','g','Liters','ml','gallon') NOT NULL,
  `Amount` decimal(10,2) NOT NULL,
  `Description` text DEFAULT NULL,
  `DateIncurred` date NOT NULL,
  `PaymentMethod` enum('Gcash','Cash') NOT NULL,
  `ReceiptNumber` varchar(50) DEFAULT NULL,
  `PaymentReferenceNumber` varchar(50) DEFAULT NULL,
  `Total` decimal(10,2) NOT NULL,
  `DateRecorded` datetime DEFAULT current_timestamp(),
  `ProcessedBy` enum('Admin','Cashier','Staff') NOT NULL,
  `Notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `expensesoverview`
--

INSERT INTO `expensesoverview` (`ExID`, `Category`, `ItemID`, `Qty`, `UnitOfMeasure`, `Amount`, `Description`, `DateIncurred`, `PaymentMethod`, `ReceiptNumber`, `PaymentReferenceNumber`, `Total`, `DateRecorded`, `ProcessedBy`, `Notes`) VALUES
(1, 'Food Ingredients', 1, 10.00, '', 1200.00, 'Purchased fresh chicken', '2025-01-31', 'Gcash', 'EXP12345', 'GCASH123', 1200.00, '2025-01-31 19:04:59', 'Admin', 'Stock replenishment');

-- --------------------------------------------------------

--
-- Table structure for table `inasal`
--

CREATE TABLE `inasal` (
  `ItemID` int(11) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `QTY` int(11) NOT NULL,
  `Price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inasal`
--

INSERT INTO `inasal` (`ItemID`, `ItemName`, `QTY`, `Price`) VALUES
(1, 'Hita Inasal', 50, 150.00);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `ItemID` int(11) NOT NULL,
  `ItemName` varchar(100) NOT NULL,
  `Qty` decimal(10,2) NOT NULL DEFAULT 0.00,
  `UnitOfMeasure` enum('kg','g','Liters','ml','gallon','pcs') NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `TransactionType` enum('Purchase','Delivery') NOT NULL,
  `SupplierName` varchar(100) DEFAULT NULL,
  `SupplierNumber` varchar(15) DEFAULT NULL,
  `DelDate` date DEFAULT NULL,
  `PurDate` date DEFAULT NULL,
  `ExpDate` date DEFAULT NULL,
  `PurPrice` decimal(10,2) DEFAULT NULL,
  `SellPrice` decimal(10,2) DEFAULT NULL,
  `Perishable` enum('Yes','No') NOT NULL DEFAULT 'No',
  `ReorderLevel` int(11) NOT NULL DEFAULT 0,
  `DateRecorded` datetime DEFAULT current_timestamp(),
  `ProcessedBy` enum('Admin','Cashier','Staff') NOT NULL,
  `Notes` text DEFAULT NULL,
  `Total` decimal(10,2) GENERATED ALWAYS AS (`Price` * `Qty`) STORED
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`ItemID`, `ItemName`, `Qty`, `UnitOfMeasure`, `Price`, `TransactionType`, `SupplierName`, `SupplierNumber`, `DelDate`, `PurDate`, `ExpDate`, `PurPrice`, `SellPrice`, `Perishable`, `ReorderLevel`, `DateRecorded`, `ProcessedBy`, `Notes`) VALUES
(1, 'Hita Inasal', 50.00, 'pcs', 150.00, 'Purchase', 'ABC Supplier', '0987654321', '2025-01-31', '2025-01-31', '2025-02-03', 120.00, 150.00, 'Yes', 10, '2025-01-31 19:04:59', 'Admin', 'Fresh stock');

-- --------------------------------------------------------

--
-- Table structure for table `receipt`
--

CREATE TABLE `receipt` (
  `ReceiptID` int(11) NOT NULL,
  `ReceiptNumber` varchar(20) NOT NULL,
  `Purdate` datetime NOT NULL,
  `ProcessedBy` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `SID` int(11) NOT NULL,
  `CID` int(11) DEFAULT NULL,
  `ReceiptNumber` varchar(50) NOT NULL,
  `TimeOrdered` datetime NOT NULL,
  `DateOrdered` date NOT NULL,
  `ItemsOrdered` varchar(255) DEFAULT NULL,
  `QTY` int(11) DEFAULT NULL,
  `SubTotal` decimal(10,2) NOT NULL,
  `DiscountAmount` decimal(10,2) DEFAULT 0.00,
  `NetAmount` decimal(10,2) NOT NULL,
  `PaymentMethod` enum('Gcash','Cash') NOT NULL,
  `TransactionType` enum('Dine-in','Take-out') NOT NULL,
  `OrderStatus` enum('Completed','Pending','Cancelled') NOT NULL,
  `RefundStatus` enum('Yes','No') NOT NULL DEFAULT 'No',
  `DateRecorded` datetime DEFAULT current_timestamp(),
  `ProcessedBy` enum('Admin','Cashier','Staff') NOT NULL,
  `Notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`SID`, `CID`, `ReceiptNumber`, `TimeOrdered`, `DateOrdered`, `ItemsOrdered`, `QTY`, `SubTotal`, `DiscountAmount`, `NetAmount`, `PaymentMethod`, `TransactionType`, `OrderStatus`, `RefundStatus`, `DateRecorded`, `ProcessedBy`, `Notes`) VALUES
(1, 1, 'RCPT12345', '2025-01-31 19:04:59', '2025-01-31', '1', 2, 300.00, 30.00, 270.00, 'Cash', 'Dine-in', 'Completed', 'No', '2025-01-31 19:04:59', 'Cashier', 'Paid in full');

-- --------------------------------------------------------

--
-- Table structure for table `silogmeals`
--

CREATE TABLE `silogmeals` (
  `ItemID` int(11) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `QTY` int(11) NOT NULL,
  `Price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `beverages`
--
ALTER TABLE `beverages`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `coffees`
--
ALTER TABLE `coffees`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CID`),
  ADD UNIQUE KEY `ReceiptNumber` (`ReceiptNumber`);

--
-- Indexes for table `desserts`
--
ALTER TABLE `desserts`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `expensesoverview`
--
ALTER TABLE `expensesoverview`
  ADD PRIMARY KEY (`ExID`),
  ADD KEY `FK_Inventory_Expenses` (`ItemID`);

--
-- Indexes for table `inasal`
--
ALTER TABLE `inasal`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `receipt`
--
ALTER TABLE `receipt`
  ADD PRIMARY KEY (`ReceiptID`),
  ADD UNIQUE KEY `ReceiptNumber` (`ReceiptNumber`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`SID`),
  ADD UNIQUE KEY `ReceiptNumber` (`ReceiptNumber`),
  ADD KEY `FK_Customer_Sales` (`CID`);

--
-- Indexes for table `silogmeals`
--
ALTER TABLE `silogmeals`
  ADD PRIMARY KEY (`ItemID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `CID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `EID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `expensesoverview`
--
ALTER TABLE `expensesoverview`
  MODIFY `ExID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `ItemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `receipt`
--
ALTER TABLE `receipt`
  MODIFY `ReceiptID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `SID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `beverages`
--
ALTER TABLE `beverages`
  ADD CONSTRAINT `beverages_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `inventory` (`ItemID`) ON DELETE CASCADE;

--
-- Constraints for table `coffees`
--
ALTER TABLE `coffees`
  ADD CONSTRAINT `coffees_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `inventory` (`ItemID`) ON DELETE CASCADE;

--
-- Constraints for table `desserts`
--
ALTER TABLE `desserts`
  ADD CONSTRAINT `desserts_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `inventory` (`ItemID`) ON DELETE CASCADE;

--
-- Constraints for table `expensesoverview`
--
ALTER TABLE `expensesoverview`
  ADD CONSTRAINT `FK_Inventory_Expenses` FOREIGN KEY (`ItemID`) REFERENCES `inventory` (`ItemID`) ON DELETE SET NULL,
  ADD CONSTRAINT `expensesoverview_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `inventory` (`ItemID`) ON DELETE SET NULL;

--
-- Constraints for table `inasal`
--
ALTER TABLE `inasal`
  ADD CONSTRAINT `inasal_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `inventory` (`ItemID`) ON DELETE CASCADE;

--
-- Constraints for table `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `FK_Customer_Sales` FOREIGN KEY (`CID`) REFERENCES `customer` (`CID`) ON DELETE CASCADE,
  ADD CONSTRAINT `sales_ibfk_1` FOREIGN KEY (`CID`) REFERENCES `customer` (`CID`) ON DELETE CASCADE;

--
-- Constraints for table `silogmeals`
--
ALTER TABLE `silogmeals`
  ADD CONSTRAINT `silogmeals_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `inventory` (`ItemID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
