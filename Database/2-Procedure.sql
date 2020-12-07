CREATE PROCEDURE Register_trade(@val          DECIMAL, 
                                @ClientSector VARCHAR(10)) 
AS 
  BEGIN 
      DECLARE @IdClientSector INTEGER, 
              @IdCategory     INTEGER 

      SELECT @IdClientSector = id_client_sector 
      FROM   tb_client_sector 
      WHERE  Upper(NAME) = Upper(@ClientSector); 

      SELECT @IdCategory = CASE 
                             WHEN @val < 1000000 
                                  AND @IdClientSector = 2 THEN 1 
                             WHEN @val > 1000000 
                                  AND @IdClientSector = 2 THEN 2 
                             WHEN @val > 1000000 
                                  AND @IdClientSector = 1 THEN 3 
                           END 

      INSERT INTO tb_trade 
                  (value, 
                   id_client_sector, 
                   id_category) 
      VALUES      (@val, 
                   @IdClientSector, 
                   @IdCategory) 
  END 