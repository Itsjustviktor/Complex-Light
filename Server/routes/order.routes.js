const Router = require('express')
const router = new Router()

const GoodController = require('../controllers/order.controllers')
//импорт объекта контроллера для использования функций

router.post('/order', GoodController.getOrder)

//определяем маршрут по которому она будет отрабатывать





module.exports = router