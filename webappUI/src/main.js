import Vue from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify';
import '@mdi/font/css/materialdesignicons.css';
import '@fortawesome/fontawesome-free/css/all.css' // Ensure you are using
import VueRouter from 'vue-router'
import routes from "./routes"
import { store } from './store'
import Vuex from 'vuex'
import axios from 'axios'


Vue.use(Vuex);

import Vuetify from 'vuetify/lib'

Vue.use(Vuetify);
Vue.use(VueRouter);

const base = axios.create({
  baseURL: 'https://cloudnative.ir/api/'
});
Vue.prototype.$http = base;


export default new Vuetify({
  icons: {
    iconfont: 'fa',
  },
})

Vue.config.productionTip = false;
const router = new VueRouter({routes});


new Vue({
  vuetify,
  router,
  icons: {
    iconfont: 'fa',
  },
    store,
  render: h => h(App)
}).$mount('#app')

