Usage:
CreateIndex.exe -server[-s] server
                -index[-i] indexname
                -field fieldname[.fieldtype][.stored|not_stored] // add indexed field - defaults .Text.stored
                -field ...
                -storedfield[-sfield] fieldname[.fieldtype]  // add stored field - defaults .Text
                -storedfield ...
                -primary primary-search-fieldname  // default: first field
                -remove  // remove existing index first

Example (Powershell):

.\CreateIndex.exe -s https://localhost:44393    `
                  -i new-index                  `
                  -f suggested_text             `
                  -f sub_text                   `
                  -f category                   `
                  -sfield id        



.\CreateIndex.exe -s http://localhost:15000													`
					-i text_model															`
					-db-type Oracle															`
					-db Data Source=192.168.0.233/UCETMVD;User ID=texp;Password=uzb;		`
					-sql SELECT sm.SP_ID AS ID, sm.SP_NAME as NAME FROM TEXP.ST_MODEL sm	`
					-f id {{ID}}															`
					-f name {{NAME}}														`
					-storedfield name														`
					-primary id        
					
					
-s http://localhost:15000 -i text_model1111	-f id  -sfield name	 -primary id        					