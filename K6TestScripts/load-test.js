import http from 'k6/http';
import { sleep } from 'k6';
import * as config from './config.js';

export const options = {

    // Ramp up to 5 users over 5 seconds
    // Stay at 5 users for 30 seconds (“normal” load)
    // Ramp up to 20 users over 5 seconds
    // Stay at 20 users for 30 seconds (“peak” load)
    // Ramp down to 5 users over 5 seconds
    // Stay at 5 users for 30 seconds
    // Ramp down to 0 users over 5 seconds

    // total 20 VU
    // telling k6 that we want at least 95% of requests to respond in < 600 ms
    
    stages: [
        { duration: '5s', target: 5 },
        { duration: '30s', target: 5 },
        { duration: '5s', target: 20 },
        { duration: '30s', target: 20 },
        { duration: '5s', target: 5 },
        { duration: '30s', target: 5 },
        { duration: '5s', target: 0 },
    ],
    thresholds: {
        http_req_duration: ['p(95)<600'],
    },
};

export default () => {
    http.get(config.API_REVERSE_URL);
    sleep(1);
};