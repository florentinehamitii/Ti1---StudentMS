Create procedure usp_GetLogInCredentials("SELECT COUNT(*) FROM login WHERE username='"+ textBox1.Text +"' AND password='"+ textBox2.Text +"'",con)
go