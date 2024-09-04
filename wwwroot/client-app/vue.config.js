const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
    devServer: {
        port: 7044,
        proxy: {
            '/api': {
                target: 'https://localhost:7043',
                changeOrigin: true,
                secure: false,
            }
        }
    }
})
