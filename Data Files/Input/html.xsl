<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method="html"/>
	<!-- Stylesheet copyright (C) 2011 LA Solutions                 -->
	<!-- Converts XML to HTML        		                            -->
	<!-- Root is dgn-chronographer                          	      -->
	<!-- Updated 02-Mar-2011                                	      -->
	<!-- Created 02-Mar-2011                                	      -->
	<xsl:template match="dgn-chronographer">
		<xsl:apply-templates select="elements"/>
	</xsl:template>
	<!-- Extract table data from XML source                 -->
	<xsl:template match="elements">
		<html>
			<head>
				<title>Example Report</title>
				<!-- Your browser will look for the .css stylesheet in the same folder as your .htm file -->
				<link rel="stylesheet" type="text/css" href="XmlTransformer.css"/>
			</head>
			<body>
				<!-- We've assigned class="xxx" attributes to some tables and text, -->
				<!-- which enables the Cascading Style Sheet (CSS) to apply distinct formatting -->
				<table class="header" width="100%">
					<tr>
						<td width="30%" align="left">
							<span class="product">XmlTransformer<sup>
									<small>&#x2122;</small>
								</sup>
							</span>
						</td>
						<td width="30%" align="right">
							<span class="la">LA Solutions</span>
						</td>
					</tr>
				</table>
				<hr/>
				<h4>Start: <xsl:call-template name="FormatDate">
						<xsl:with-param name="DateTime" select="start-date"/>
					</xsl:call-template>
				</h4>
				<h4>End: <xsl:call-template name="FormatDate">
						<xsl:with-param name="DateTime" select="end-date"/>
					</xsl:call-template>
				</h4>
				<!-- The  <elements> element contains a list of element data -->
				<table>
					<tbody>
						<tr>
							<th>Element ID</th>
							<th>Level</th>
							<th>Model</th>
							<th>File</th>
						</tr>
						<xsl:apply-templates select="element"/>
					</tbody>
				</table>
				<hr/>
				<p>
					<a href="http://www.la-solutions.co.uk/content/DotNet/XmlTransformer.htm">DGN&#160;XmlTransformer</a> is a tool for transforming XML
						documents to HTML.
			</p>
				<hr/>
				<table class="address" width="80%" align="center">
					<tr>
						<td>
							<a href="http://www.la-solutions.co.uk">LA Solutions Ltd</a>
						</td>
						<td>tel: +44 1984 656 512</td>
					</tr>
					<tr>
						<td>Old Mill Barn<br/>Northam Mill<br/>Stogumber<br/>Somerset<br/>TA4 3TT</td>
						<td>UK</td>
					</tr>
				</table>
			</body>
		</html>
	</xsl:template>
	<xsl:template match="element">
		<!-- The  <elements> element contains a list of element data -->
		<xsl:apply-templates select="element"/>
	</xsl:template>
	<xsl:template match="element">
		<tr>
			<td>
				<xsl:value-of select="@id"/>
			</td>
			<td>
				<xsl:value-of select="level-name"/>
			</td>
			<td>
				<xsl:value-of select="model-name"/>
			</td>
			<td>
				<xsl:call-template name="filename-only" ><xsl:with-param name="path" select="file-name" ></xsl:with-param></xsl:call-template>
				<!-- <xsl:value-of select="file-name"/> -->
			</td>
		</tr>
	</xsl:template>
	<!-- Format a date provided in ISO format -->
	<xsl:template name="FormatDate">
		<xsl:param name="DateTime"/>
		<xsl:variable name="mo">
			<xsl:value-of select="substring($DateTime,6,2)"/>
		</xsl:variable>
		<xsl:variable name="day">
			<xsl:value-of select="substring($DateTime,9,2)"/>
		</xsl:variable>
		<xsl:variable name="year">
			<xsl:value-of select="substring($DateTime,1,4)"/>
		</xsl:variable>
		<xsl:variable name="time">
			<xsl:value-of select="substring($DateTime,12,8)"/>
		</xsl:variable>
		<xsl:variable name="hh">
			<xsl:value-of select="substring($time,1,2)"/>
		</xsl:variable>
		<xsl:variable name="mm">
			<xsl:value-of select="substring($time,4,2)"/>
		</xsl:variable>
		<xsl:variable name="ss">
			<xsl:value-of select="substring($time,7,2)"/>
		</xsl:variable>
		<xsl:value-of select="$day"/>
		<xsl:value-of select="'-'"/>
		<xsl:call-template name="convertMonth" ><xsl:with-param name="month-as-number" select="$mo" ></xsl:with-param></xsl:call-template>
		<xsl:value-of select="'-'"/>
		<xsl:value-of select="$year"/>
		<xsl:value-of select="' '"/>
		<xsl:value-of select="$hh"/>
		<xsl:value-of select="':'"/>
		<xsl:value-of select="$mm"/>
		<xsl:value-of select="':'"/>
		<xsl:value-of select="$ss"/>
	</xsl:template>
	<!-- Convert a number month index (1..12) to a short name -->
	<xsl:template name="convertMonth">
		<xsl:param name="month-as-number" />
		<xsl:choose>
			<xsl:when test="$month-as-number=1">Jan</xsl:when>
			<xsl:when test="$month-as-number=2">Feb</xsl:when>
			<xsl:when test="$month-as-number=3">Mar</xsl:when>
			<xsl:when test="$month-as-number=4">Apr</xsl:when>
			<xsl:when test="$month-as-number=5">May</xsl:when>
			<xsl:when test="$month-as-number=6">Jun</xsl:when>
			<xsl:when test="$month-as-number=7">Jul</xsl:when>
			<xsl:when test="$month-as-number=8">Aug</xsl:when>
			<xsl:when test="$month-as-number=9">Sep</xsl:when>
			<xsl:when test="$month-as-number=10">Oct</xsl:when>
			<xsl:when test="$month-as-number=11">Nov</xsl:when>
			<xsl:when test="$month-as-number=12">Dec</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="concat('[invalid month: ', '$month-as-number')"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<!-- Parse a file name from a full path -->
	<xsl:template name="filename-only">
	    <xsl:param name="path" />
	    <xsl:choose>
	        <xsl:when test="contains($path, '\')">
	            <xsl:call-template name="filename-only">
	                <xsl:with-param name="path" select="substring-after($path, '\')" />
	            </xsl:call-template>
	        </xsl:when>
	        <xsl:otherwise>
	            <xsl:value-of select="$path" />
	        </xsl:otherwise>
	    </xsl:choose>
	</xsl:template>

</xsl:stylesheet>
