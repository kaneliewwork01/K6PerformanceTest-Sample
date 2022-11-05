import http from 'k6/http';
import { sleep } from 'k6';
import * as config from './config.js'; // refering to config.js

export const options = {
    // setting the vus to 1 (default),
    // running for 1 minute
    // telling k6 that we want at least 95% of requests to respond in < 1 second
    vus: 1,
    duration: '1m',
    thresholds: {
        http_req_duration: ['p(95)<5000']
    }
};

export default function () {
    http.get(config.API_LOGIN_URL);
    sleep(1);   

    http.get(config.API_GETPRODUCT_URL);
    sleep(1);   

    http.get(config.API_ADDTOCART_URL);
    sleep(1);   

    http.get(config.API_CHECKOUT_URL);
    sleep(1);   

    http.get(config.API_PAYMENT_URL);
    sleep(1);   
}