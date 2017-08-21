const Path = require('path');
const Webpack = require('webpack');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const ExtractTextPlugin = require("extract-text-webpack-plugin");
const CleanWebpackPlugin = require('clean-webpack-plugin');
const ServiceWorkerWebpackPlugin = require('serviceworker-webpack-plugin');

var getPathFromRoot = function (path) {
    return Path.join(__dirname, path)
};

module.exports = {
    entry: {
        'polyfills': getPathFromRoot('app/polyfills.ts'),
        'vendor': getPathFromRoot('app/vendor.ts'),
        'main': getPathFromRoot('app/main.ts'),
    },
    output: {
        path: getPathFromRoot('wwwroot'),
        filename: '[name].bundle.js',
        chunkFilename: '[id].chunk.js',
        publicPath: '/'
    },
    resolve: {
        extensions: ['.ts', '.tsx', '.js'] // note if using webpack 1 you'd also need a '' in the array as well
    },
    module: {
        loaders: [
            {
                test: /\.ts$/,
                loaders: [
                    {
                        loader: 'awesome-typescript-loader',
                        options: {configFileName: 'tsconfig.json'}
                    }, 'angular2-template-loader'
                ]
            },
            {
                test: /\.html$/,
                loader: 'html-loader'
            },
            {
                test: /\.css$/,
                use: ExtractTextPlugin.extract({
                    fallback: "style-loader",
                    use: "css-loader"
                })
            },
            {
                test: /\.woff(\?v=\d+\.\d+\.\d+)?$/,
                use: [{
                    loader: "url-loader?limit=10000&mimetype=application/font-woff",
                    options: {
                        name: '[name].[ext]',
                        outputPath: 'fonts/'
                    }
                }]
            }, {
                test: /\.woff2(\?v=\d+\.\d+\.\d+)?$/,
                use: [{
                    loader: "url-loader?limit=10000&mimetype=application/font-woff",
                    options: {
                        name: '[name].[ext]',
                        outputPath: 'fonts/'
                    }
                }]
            }, {
                test: /\.ttf(\?v=\d+\.\d+\.\d+)?$/,
                use: [{
                    loader: "url-loader?limit=10000&mimetype=application/octet-stream",
                    options: {
                        name: '[name].[ext]',
                        outputPath: 'fonts/'
                    }
                }]
            }, {
                test: /\.eot(\?v=\d+\.\d+\.\d+)?$/,
                use: [{
                    loader: 'file-loader',
                    options: {
                        name: '[name].[ext]',
                        outputPath: 'fonts/'
                    }
                }]
            },
            {
                test: /\.svg(\?v=\d+\.\d+\.\d+)?$/,
                use: [{
                    loader: "url-loader?limit=10000&mimetype=image/svg+xml",
                    options: {
                        name: '[name].[ext]',
                        outputPath: 'fonts/'
                    }
                }]
            },
            {
                test: /\.(png|jpg|gif)$/,
                use: [
                    {
                        loader: 'file-loader',
                        options: {
                            name: '[name].[ext]',
                            outputPath: 'img/'
                        }
                    }
                ]
            }
        ]
    },
    plugins: [
        new Webpack.ProvidePlugin({
            $: "jquery",
            jquery: "jQuery",
            "windows.jQuery": "jquery"
        }),
        new HtmlWebpackPlugin({
            chunks:['polyfills','vendor','main'],
            chunksSortMode: 'manual',
            favicon: getPathFromRoot('app/favicon.ico'),
            filename: 'index.html',
            template: getPathFromRoot('app/index.html'),
        }),
        new ExtractTextPlugin("css/styles.css"),
        new CleanWebpackPlugin('wwwroot'),
        new Webpack.ContextReplacementPlugin(
            /angular(\\|\/)core(\\|\/)@angular/, /angular(\\|\/)core(\\|\/)(esm(\\|\/)src|src)(\\|\/)linker/,
            getPathFromRoot('app'),
            {}
        ),
        new ServiceWorkerWebpackPlugin({
            entry: getPathFromRoot('app/sw.ts')
        })
    ]
};
