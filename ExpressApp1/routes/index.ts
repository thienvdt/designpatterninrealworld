/*
 * GET home page.
 */
import express = require('express');
const router = express.Router();

router.get('/', (req: express.Request, res: express.Response) => {
    let name = 'Alex Vo';
    res.render('index', { title: name });
});

export default router;