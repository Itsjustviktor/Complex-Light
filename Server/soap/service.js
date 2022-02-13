const db = require('../db.js');
var service_orders = {
    Orders_Service: {
        Orders_Port: {

            createOrder: async function (args) {
                const { Idorder, Status, Priceoreder, Paymentmethod, Takemethod, Idbuyer, Tracknum, Adress, Date } = JSON.parse(args.value_json);
                try {
                    const res = await db.query("INSERT INTO public.order(status, priceoreder, paymentmethod, takemethod, idbuyer, tracknum, adress) VALUES ('"+Status+"',"+Priceoreder+",'"+String(Paymentmethod)+"','"+Takemethod+"',"+Idbuyer+",'"+Tracknum+"','"+Adress+"') RETURNING idorder;")
                    console.log("Added an entry to the 'order'");
                    console.log(Idorder, Status, Priceoreder, Paymentmethod, Takemethod, Idbuyer, Tracknum, Adress, Date);
                    return {bmi: res.rows[0].idorder};
                }
                catch (e) {
                    console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
                    return { bmi: "-1" };
                }
            },
            createOrderedGood: async function (args) {
                const {Idorderedgoods, Idgood, Quantityorderedgoods, Price, Idorder} = JSON.parse(args.value_json);
                try {
                    await db.query('INSERT INTO public.orderedgoods(idgood, quantityorderedgoods, price, idorder) VALUES ($1, $2, $3, $4);',
                        [Idgood, Quantityorderedgoods, Price, Idorder]);
                    console.log(Idgood, Quantityorderedgoods, Price, Idorder);
                    console.log("Added an entry to the 'orderedgoods'");
                    return { bmi: "0" };
                }
                catch (e) {
                    console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
                    return { bmi: "-1" };
                }
            }
        }
    }
}

module.exports = service_orders;