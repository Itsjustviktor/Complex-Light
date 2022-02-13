const db = require('../db')

class UserController{
    async createUser(req,res){
        console.log(req.body)
        const {Idbuyer, First, Second,Third,Telephonebuyer,Emailbuyer,Login,Password} = req.body
        const newBuyer = await db.query('INSERT INTO buyer (first, second, third, telephonebuyer, emailbuyer, login, password) values($1,$2,$3,$4,$5,$6,$7) RETURNING *', [First, Second,Third,Telephonebuyer,Emailbuyer,Login,Password])
        //вместо $1... подставляется массив с данными, стобцы начинаются с 0
        res.json(newBuyer.rows[0])

    }//создать пользователя

    async getUsers(req,res){
        const {idbuyer,first,second,third,telephonebuyer,emailbuyer,login,password} = req.body
        const Buyers = await db.query('SELECT * FROM buyer')
        res.json(Buyers.rows)
    }//получить пользователей


}

module.exports = new UserController()