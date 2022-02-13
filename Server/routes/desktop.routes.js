const Router = require('express')
const router = new Router()

const Controller = require('../controllers/desktop.controller')
//импорт объекта контроллера для использования функций

router.post('/any', Controller.getAny)
router.put('/any', Controller.putAny)
router.post('/create_any', Controller.postAny)


//определяем маршрут по которому она будет отрабатывать

module.exports = router