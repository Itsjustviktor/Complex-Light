const Router = require('express')
const router = new Router()

const UserController = require('../controllers/user.controllers')
//импорт объекта контроллера для использования функций

router.post('/user', UserController.createUser)
router.post('/getuser', UserController.getUsers)


//определяем маршрут по которому она будет отрабатывать





module.exports = router