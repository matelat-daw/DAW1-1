<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:strip-space elements="*"/>
  <xsl:template match="Articulos">
    <articulos>
      <xsl:apply-templates select="Articulo"/>
    </articulos>
  </xsl:template>
  <xsl:template match="Articulo">
    <articulo>
      <xsl:attribute name="identificador">
        <xsl:value-of select="issn"/>
      </xsl:attribute>
      <xsl:attribute name="año">
        <xsl:value-of select="fecha"/>
      </xsl:attribute>
      <titulo>
        <xsl:value-of select="nombre"/>
      </titulo>
      <institucion>
        <xsl:value-of select="editor"/>
      </institucion>
      <autores>
        <xsl:apply-templates select="autor"/>
      </autores>
    </articulo>
  </xsl:template>
  <xsl:template match="autor">
    <autor>
      <xsl:value-of select="."/>
    </autor>
  </xsl:template>
</xsl:stylesheet>