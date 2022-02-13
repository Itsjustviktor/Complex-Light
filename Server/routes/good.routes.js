const Router = require('express')
const router = new Router()

const goodController = require('../controllers/good.controllers')
//импорт объекта контроллера для использования функций

router.post('/good', goodController.postGood)
router.post('/updategood', goodController.updateGood)

//определяем маршрут по которому она будет отрабатывать





module.exports = router