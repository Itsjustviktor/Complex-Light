const db = require('../db')

class OrderController{
    async getOrder(req,res){
        const {Idorder, Status, Priceoreder, Paymentmethod, Takemethod, Idbuyer, Tracknum, Adress, Date} = req.body
        const Order = await db.query('SELECT * FROM public.order')
        console.log(Order.rows)
        res.json(Order.rows)
    }//получить пользователя

}

module.exports = new OrderController()