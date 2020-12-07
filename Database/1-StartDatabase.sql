IF Object_id('TB_CLIENT_SECTOR') IS NULL 
  BEGIN 
      CREATE TABLE TB_CLIENT_SECTOR 
        ( 
           Id_client_sector INTEGER IDENTITY PRIMARY KEY NOT NULL, 
           NAME             VARCHAR(10) 
        ) 

      INSERT INTO TB_CLIENT_SECTOR 
      VALUES     ('Private') 

      INSERT INTO TB_CLIENT_SECTOR 
      VALUES     ('Public') 
  END 

IF Object_id('TB_CATEGORY') IS NULL 
  BEGIN 
      CREATE TABLE TB_CATEGORY 
        ( 
           Id_category INT NOT NULL PRIMARY KEY, 
           NAME        VARCHAR(20) 
        ) 

      INSERT INTO TB_CATEGORY 
      VALUES      (1, 'LOWRISK') 

      INSERT INTO TB_CATEGORY 
      VALUES      (2,'MEDIUMRISK') 

      INSERT INTO TB_CATEGORY 
      VALUES      (3,'HIGHRISK') 
  END 

IF Object_id('TB_TRADE') IS NULL 
  BEGIN 
      CREATE TABLE TB_TRADE 
        ( 
           Id_trade         INTEGER IDENTITY NOT NULL PRIMARY KEY, 
           Value            DECIMAL, 
           Id_client_sector INTEGER FOREIGN KEY REFERENCES TB_CLIENT_SECTOR( 
           Id_client_sector), 
           Id_category      INTEGER NULL FOREIGN KEY REFERENCES TB_CATEGORY( 
           Id_category) 
        ) 
  END 