"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
/*
 * GET home page.
 */
const express = require("express");
const router = express.Router();
router.get('/', (req, res) => {
    let name = 'Alex Vo';
    res.render('index', { title: name });
});
exports.default = router;
//# sourceMappingURL=index.js.map