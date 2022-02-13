 //запуск сервера
 const express = require('express')
 const db = require('./db')
 const userRouter = require('./routes/user.routes')
 const goodRouter = require('./routes/good.routes')
 const orderRouter = require('./routes/order.routes')
 const deskRouter = require('./routes/desktop.routes')
 const soap = require('soap'); const service_orders = require("./soap/service");
 const xml_orders = require("./soap/wsdl");
 

 const PORT = process.env.PORT || 50 
const urlencodedParser = express.urlencoded({extended: false})
 const app = express()
 
 const apptows = express()
 http = require('http').createServer(apptows);
 wsServer = require('socket.io')(http)
 


 app.use(express.json())
 apptows.use(express.json())
app.use ('/api', userRouter)
app.use ('/api', goodRouter)
app.use ('/api', orderRouter)
app.use ('/desktop', deskRouter)

 var server= app.listen(PORT, console.log('server started on post ', PORT));
 soap.listen(server, '/interation', service_orders, xml_orders);//взаимодействие с orders


 apptows.get('/', (req, res) => res.json('НИГГЕРС'))
 wsServer.on('connection', (socket) => {
  console.log(`Client with id ${socket.id} connected`)
  clients.push(socket.id)

  socket.emit('message', "I'm server")

  socket.on('message', (message) =>{ 
      console.log('Message: ', message);
      io.sockets.emit('message', 'Клиент присоединился');
  })

  socket.on('disconnect', () => {
      clients.splice(clients.indexOf(socket.id), 1)
      console.log(`Client with id ${socket.id} disconnected`)
  })
})

apptows.post('/feedback', async function (req, res)  
{
  const {Idfeedback,Firstname,Problem,Solve,Telnumber,End} = req.body
        console.log([Firstname, Telnumber, End])
        const feedback = await db.query('INSERT INTO feedback (firstname, telnumber, "end") values($1,$2,$3) RETURNING *', [Firstname, Telnumber, End])
        console.log(feedback.rows[0])
        res.json(feedback.rows[0])
})

const host = '127.0.0.1'
const port = 9000
http.listen(port, host, () =>
  console.log(`Server listens http://${host}:${port}`)
);





