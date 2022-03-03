ImportDbTable.exe -s http://localhost:15000	-i text_model1111 -db-type Oracle -db "Data Source=192.168.0.233/UCETMVD;User ID=texp;Password=uzb;" -sql "SELECT sm.SP_ID AS ID, sm.SP_NAME as NAME FROM TEXP.ST_MODEL sm"	-f id {{ID}} -f name {{NAME}}
					


