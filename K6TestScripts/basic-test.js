import http from 'k6/http';
import { sleep } from 'k6';

export default function() {
    http.get('https://localhost:7213/api/String/reverse?input=emosewa%C2%A0si%C2%A0ezamedoc');

    // sleeps for 1 second. The sleep is used to control the pace of our tests, and to simulate normal user behavior.
    sleep(1);
}