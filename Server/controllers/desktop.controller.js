const db = require('../db')

class DesktopController{

    async getAny(req,res){
        const {sql_str} = req.body
        console.log("Запрос на получение: " +sql_str)
        const result = await db.query(sql_str)
        res.json(result.rows)
    }//получает запрос к бд и выполняет его

    async putAny(req,res){
        const {sql_str} = req.body
        console.log("Запрос на обновление: " +sql_str)
        try{
            const result = await db.query(sql_str)
            
            res.json(0)
        }
        catch(err){
            console.log(err)
            res.json(-1)
        }
    }//получает запрос к бд и выполняет его (UPDATE)
    async postAny(req,res){
        const {sql_str} = req.body
        console.log("Запрос на добавление: " +sql_str)
        try{
            await db.query(sql_str)
            res.json(0)
        }
        catch(err){
            console.log(err)
            res.json(-1)
        }
    }//получает запрос к бд и выполняет его (INSERT)
   
}

module.exports = new DesktopController()