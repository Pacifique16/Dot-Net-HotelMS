-- Add User_Role column to HOTEL_USERSS table
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[HOTEL_USERSS]') AND name = 'User_Role')
BEGIN
    ALTER TABLE HOTEL_USERSS ADD User_Role NVARCHAR(50) DEFAULT 'Receptionist' NOT NULL;
END
GO

-- Update existing users to have a default role
UPDATE HOTEL_USERSS SET User_Role = 'Receptionist' WHERE User_Role IS NULL;
GO
