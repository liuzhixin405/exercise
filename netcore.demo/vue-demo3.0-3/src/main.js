import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import axios from 'axios'

import './assets/font/iconfont.css'

import VueCompositionApi from '@vue/composition-api'
Vue.use(VueCompositionApi)

axios.defaults.baseURL = 'http://127.0.0.1:7002/'
Vue.prototype.$http = axios;

Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
