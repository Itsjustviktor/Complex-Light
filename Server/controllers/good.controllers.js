const db = require('../db')

class GoodController {
    async postGood(req, res) {
        const { Idgood, Name, Price, Dimension, Provider, Weight, Length, Width, Height, Category, Subcategory, Guarantee, Quantity, Availability, Firm, Subfirm, Picture, Picture2, Picture3, P1, P2, P3 } = req.body
        const Good = await db.query('SELECT * FROM good')
        res.json(Good.rows)
    }//создать пользователя

    async updateGood(req, res) 
    {
        const { Idgood, Name, Price, Dimension, Provider, Weight, Length, Width, Height, Category, Subcategory, Guarantee, Quantity, Availability, Firm, Subfirm, Picture, Picture2, Picture3, P1, P2, P3 } = req.body;
        try {
            //console.log([Idgood, Name, Price, Dimension, Provider, Weight, Length, Width, Height, Category, Subcategory, Guarantee, Quantity, Availability, Firm, Subfirm, Picture, Picture2, Picture3, P1, P2, P3 ])
            await db.query("UPDATE public.good SET quantity="+Quantity+" WHERE idgood ="+Idgood+";")
            res.json(0);
        }
        catch (e) {
            console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
            res.json(-1);
        }
    }
}

module.exports = new GoodController()