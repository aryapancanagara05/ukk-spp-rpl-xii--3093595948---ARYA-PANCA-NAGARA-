<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class pembayaran extends Model
{
    protected $fillable = [
        'id_pembayaran',
        'nisn',
        'tgl_bayar',
        'bulan_dibayar',
        'tahun_dibayar',
        'id_app',
        'jumlah_bayar',
        'created_at',
        'update_at'
    ];
}
